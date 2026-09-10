using Bootcamp_MVC_EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_MVC_EF.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            IList<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 3500, CategoryName = "Electronics" },
                new Product { Id = 2, Name = "Huawei P30", Price = 4200, CategoryName = "Mobiles" },
                new Product { Id = 3, Name = "nike", Price = 2250, CategoryName = "shoes" }
            };

            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}
