using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyMovieRentalApp.Dtos;
using VidlyMovieRentalApp.Models;

namespace VidlyMovieRentalApp.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalsDto newRentalsDto)
        {
           

            var movies = _context.Movies.Where(m => newRentalsDto.MovieIds.Contains(m.Id)).ToList();

            var customers = _context.Customers.Single(c => c.Id == newRentalsDto.CustomerId);

            if (movies.Count != newRentalsDto.MovieIds.Count)
            {
                return BadRequest("One or more movies are invalid!");
            }


            try
            {
                foreach (var movie in movies)
                {
                    if (movie.NumberAvailible == 0)
                    {
                        return BadRequest("Movie is not avalible.");
                    }

                    movie.NumberAvailible--;
                    var rentals = new Rental
                    {
                        Customer = customers,
                        Movie = movie,
                        DateRented = DateTime.Now,
                    };
                    _context.Rentals.Add(rentals);

                }


                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            return Ok();
        }
    }
}
