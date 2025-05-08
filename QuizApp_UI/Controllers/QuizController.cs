using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuizApp_UI.Models;
using QuizApp_UI.Service;

namespace QuizApp_UI.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        public async Task<IActionResult> Quiz()
        {
            List<QuizApp_UI.Models.Quiz> list = new();
            var response = await _quizService.GetAllQuizzes<APIResponse>();
            if (response != null && response.IsSuccess && response.Result != null)
            {
                list = JsonConvert.DeserializeObject<List<QuizApp_UI.Models.Quiz>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }

}
