using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using VidlyMovieRentalApp.Models;
using VidlyMovieRentalApp.ViewModels;

namespace VidlyMovieRentalApp.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }





    }
}

