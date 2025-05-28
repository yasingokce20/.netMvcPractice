using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        //DI Consepts
        private readonly RepositoryContext _Context;
        public ProductController(RepositoryContext Context)
        {
            _Context = Context;
        }

        public IActionResult Index()
        {
            var model = _Context.Products.ToList();
            return View(model);
        } 
        
/*         public IEnumerable<Product> Index()
                        {
                            // DI olmasa idi bu şekilde alırdık
                            // var context = new RepositoryContext(
                            //     new DbContextOptionsBuilder<RepositoryContext>()
                            //     .UseSqlite("Data Source = C:\\Users\\yasin\\Desktop\\MVC\\Store\\Product.db")
                            //     .Options);

                            return _Context.Products;
                        } */


    }
}