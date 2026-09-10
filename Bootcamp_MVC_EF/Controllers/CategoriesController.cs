using Bootcamp_MVC_EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_MVC_EF.Controllers
{
    public class CategoriesController : Controller
    {

        public ActionResult Index()
        {
            IList<Category> categories = new List<Category>
            {
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Mobiles" },
                new Category { Id = 3, Name = "shoes" }
            };

            return View(categories);
        }
        public ActionResult Create()
        {
            return View();
        }



    }
}
