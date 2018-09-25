using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieRentalApp.Models;
using VidlyMovieRentalApp.ViewModels;

namespace VidlyMovieRentalApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details()
        {
            return View();
        }

        private IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie{Name = "Shrek 2"},
                new Movie { Name = "Toy Story 3"}
            };
            return movies;
        }

    }
}

