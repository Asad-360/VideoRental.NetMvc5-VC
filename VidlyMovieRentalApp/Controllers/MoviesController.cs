using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovieRentalApp.Models;

namespace VidlyMovieRentalApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };
            //ViewData["Movie"]=movie
            ViewBag.Movie = movie;
            return View();
        }
        //For Convention Based Routing use route.config
        //Attribute based Routes
        [Route("movies/released/{year:range(10,50):regex(\\d{2})}/{month}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}

