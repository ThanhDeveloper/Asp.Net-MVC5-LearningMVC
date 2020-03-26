using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidtaly.Models;

namespace Vidtaly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customers> Customers { get; set; }
    }
}