using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QuizApp_API.Model;
using QuizApp_API.Service;
using System.Net;

namespace QuizApp_API.Controllers
{
    public class QuizController : Controller
    {
        private readonly APIResponse _response;
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _response = new APIResponse();
            _quizService = quizService;
        }
        [HttpGet("all-questions")]
        public async Task<ActionResult<APIResponse>> GetQuizzes()
        {
            IEnumerable<Quiz> quizzes;
            quizzes = await _quizService.GetQuizzes();
            if (quizzes.IsNullOrEmpty())
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { "The quizzes are undefined" };
                return BadRequest();
            }
            _response.Result = quizzes;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }
    }
}
