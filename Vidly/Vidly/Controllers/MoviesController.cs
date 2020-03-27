using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidtaly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Home alone", Id = 1 };

            //return View(movie);
            //return Content("Hello worlds"); //return only content
            //return HttpNotFound(); // return 404 error
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

            var customers = new List<Customers> {
               new Customers { Name = "Customer 1",Id = 1},
               new Customers { Name = "Customer 2",Id = 2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("ID= " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }
            return Content(string.Format("pageIndex{0}&sortBy{1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}