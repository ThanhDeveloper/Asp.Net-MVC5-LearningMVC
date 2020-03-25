using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sec2Exer1.Models;

namespace Sec2Exer1.ViewModel
{
    public class CustomerViewModel
    {
        public List<Movies> MoviesList { set; get; }

        public List<Customers> CustomerList { get; set; }
    }
}