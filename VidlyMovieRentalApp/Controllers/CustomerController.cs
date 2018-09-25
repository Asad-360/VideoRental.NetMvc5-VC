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
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            //ViewBag.Id = id;
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Marry Williams", Id = 1},
                new Customer {Name = "John Doe" , Id=2}
            };

            return customers;
        }
    }
}