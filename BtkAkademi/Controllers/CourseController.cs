using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var term1 = Repository.Applications;
            return View(term1);
        }
        public IActionResult Apply()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryTokenAttribute]
        public IActionResult Apply([FromForm]Candidate term) //candidate model
        {
            if (Repository.Applications.Any(c => c.Email.Equals(term.Email)))
            {
                ModelState.AddModelError("" , " There is already  an applications for you.");
            } 
 
            if (ModelState.IsValid)
            {
                Repository.Add(term);
                return View("Feedback", term);
            }
            
            return View();
        }
    } 
}