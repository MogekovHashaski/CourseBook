using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CourseBook.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ScheduleController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET
        public IActionResult Schedule()
        {
            return View();
        }
    }
}