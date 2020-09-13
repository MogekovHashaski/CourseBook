using CourseBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseBook.Controllers
{
    public class SelectsController : Controller
    {
        // GET
        public IActionResult FacultySelection()
        {
            var model = new FacultySelectionViewModel();
            return View(model);
        }

        public IActionResult GroupSelection()
        {
            var model = new GroupSelectionViewModel();
            return View(model);
        }

        public IActionResult TeacherSelection()
        {
            var model = new TeacherSelectionViewModel();
            return View(model);
        }
    }
}