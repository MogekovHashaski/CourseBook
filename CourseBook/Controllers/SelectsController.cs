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
    }
}