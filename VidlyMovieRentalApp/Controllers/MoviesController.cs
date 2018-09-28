using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Validation;
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
        // GET: Movies/Index
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult MovieForm()
        {
            var genreList = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genreList
            };

            return View("MovieForm", viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var moviesInDb = _context.Movies.Single(m => m.Id == movie.Id);
                moviesInDb.Name = movie.Name;
                moviesInDb.ReleasedDate = movie.ReleasedDate;
                moviesInDb.GenreId = movie.GenreId;
                moviesInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }


        public ActionResult Edit(int id)
        {

            var movies = _context.Movies.SingleOrDefault(m => m.Id == id);

            var viewModel = new MovieFormViewModel
            {
                Movie = movies,
                Genres = _context.Genres
            };
            return View("MovieForm", viewModel);
        }
    }
}

