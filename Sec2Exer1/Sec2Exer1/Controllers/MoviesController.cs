using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sec2Exer1.Models;
using Sec2Exer1.ViewModel;

namespace Sec2Exer1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult RandomMovie()
        {
            var lstmovie = new List<Movies>
            {
                 new Movies { Name = "BaByShark!", ID = 1},
                 new Movies { Name = "Home Alone",ID = 2}
            };
            var viewModel = new CustomerViewModel
            {
                MoviesList = lstmovie
            };
            return View(viewModel);
        }
    }
}