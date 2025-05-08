using Microsoft.AspNetCore.Mvc;

namespace QuizApp_UI.Controllers
{
    public class QuizController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public QuizController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Quiz()
        {
            return View();
        }
    }

}
