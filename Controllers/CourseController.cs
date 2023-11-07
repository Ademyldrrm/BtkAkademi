using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController:Controller
    {
        public IActionResult Index()
        {
            var model =Repository.Aplications;
            return View(model);
        }
        [HttpGet]
         public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult Apply([FromForm]Candidate model)
        {
            Repository.Add(model);
            
            return View("Feedback",model);
        }
    }
}