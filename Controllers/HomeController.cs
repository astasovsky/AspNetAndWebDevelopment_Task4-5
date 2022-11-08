using System.Diagnostics;
using AspNetAndWebDevelopment_Task4_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetAndWebDevelopment_Task4_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Questions _question = new Questions();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Question> data = _question.GetQuestions;
            return View(data);
        }

        [Route("/Result")]
        public ViewResult Result(int result)
        {
            IEnumerable<Question> data = _question.GetQuestions;
            ViewBag.result = result;
            return View(data);
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}