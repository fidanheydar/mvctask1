using Microsoft.AspNetCore.Mvc;
using ProductTask.Models;

namespace ProductTask.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products { get; set; }

        public ProductController()
        {
            _products = new List<Product>()
            {
                new Product { Id = 1,Name="Bread",Price=11},
                new Product { Id = 2,Name="Meat", Price=22},
                new Product { Id = 3,Name="Juice",Price=6},
                new Product { Id = 4, Name="Flour",Price=9},
                new Product { Id = 5,Name="Tea" ,Price=15}
            };

        }
            public ViewResult Index()
            {
                ViewBag.Products = _products;
                return View();
            }

        public ViewResult Details(int id)
        {
            Product product = _products.FirstOrDefault(x => x.Id == id);
            ViewBag.Product = product;
            return View("Details");
        }

    }
}
