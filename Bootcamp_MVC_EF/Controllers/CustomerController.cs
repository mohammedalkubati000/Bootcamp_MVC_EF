using Bootcamp_MVC_EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_MVC_EF.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            IList<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Mohammed",  Phone = "0533678234" },
                new Customer { Id = 2, Name = "Salem", Phone = "0508867908" }
            };

            return View(customers);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}
