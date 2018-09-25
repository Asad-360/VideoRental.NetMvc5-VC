using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieRentalApp.Models;

namespace VidlyMovieRentalApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Marry Williams", Id = 1},
                new Customer {Name = "John Doe" , Id=2}
            };
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}