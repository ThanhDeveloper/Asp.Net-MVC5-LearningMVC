using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers from db

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var customers = GetCustomer();
            //var viewModel = new RandomMovieViewModel
            //{
            //    Customers = (List<Customers>)customers
            //};
            //return View(viewModel);
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.Id == id);
            if(customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //Init customer
        private IEnumerable<Customers> GetCustomer()
        {
            return new List<Customers>
            {
                new Customers {Id = 1 , Name = "John Smith"},
                new Customers {Id = 2 , Name = "Mary Williams"}
            };
        }
    }
}