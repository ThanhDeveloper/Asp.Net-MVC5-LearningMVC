using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sec2Exer1.Models;
using Sec2Exer1.ViewModel;
namespace Sec2Exer1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult RandomCustomer()
        {
          
            var lstCustomer = new List<Customers>
            {
                new Customers { CustomerName = "John Smith", CustomerID  = 1},
               new Customers { CustomerName = "Mary William",CustomerID = 2}
            };
            var viewModel = new CustomerViewModel
            {
                CustomerList = lstCustomer
            };
            return View(viewModel);
        }

        public ActionResult Detail(string customerName)
        {
            return Content("Customer Name is "+ customerName);
        }
    }
}