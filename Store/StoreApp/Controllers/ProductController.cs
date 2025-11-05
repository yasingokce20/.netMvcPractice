using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;


namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        //DI Consepts
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }


        public IActionResult Index()
        {
            var model = _manager.ProductService.GetAllProducts(false);
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


        public IActionResult Get([FromRoute(Name = "id")] int id)
        {
            //Product product = _Context.Products.First(p => p.ProductId.Equals(id));
            var model = _manager.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}