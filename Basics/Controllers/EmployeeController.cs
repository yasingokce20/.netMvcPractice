using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            String message = $"hello world {DateTime.Now.ToString()}";
            return View( "Index1", message);
            
        }

        public ViewResult Index2()
        {
            var names = new String[]{"Yasin","Rumeysa","Mücahit"};
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1 ,FirstName = "Yasin" , LastName= "Gokce" , Age=23},
                new Employee(){Id=2 ,FirstName = "Rameysa" , LastName= "Gokce" , Age=23},
                new Employee(){Id=3 ,FirstName = "Mucahit" , LastName= "Gokce" , Age=25}
            };
            return View("Index3",list);
        }

    }  
}