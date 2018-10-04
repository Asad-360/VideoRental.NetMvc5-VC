using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using VidlyMovieRentalApp.Models;
using System.Data.Entity;
using AutoMapper;
using VidlyMovieRentalApp.Dtos;

namespace VidlyMovieRentalApp.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET/api/customers
        public IHttpActionResult Getmovies()
        {
            var movies = _context
               .Movies.Include(m => m.Genre).ToList()
               .Select(Mapper.Map<Movie, MovieDto>);
            return Ok(movies);
        }


        public IHttpActionResult GetMovies(int id)
        {
            var moviesInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (moviesInDb == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Movie, MovieDto>(moviesInDb));

        }

        [HttpPost]
        public IHttpActionResult CreateMovies(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var movies = Mapper.Map<MovieDto , Movie>(movieDto);
            _context.Movies.Add(movies);
            _context.SaveChanges();
            movieDto.Id = movies.Id;
           return Created(new Uri(Request.RequestUri + "/" + movies.Id), movieDto);
        }



        [HttpPut]

        public void UpdateMovies(int id , MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var moviesInDb = _context.Movies.Single(m => m.Id == id);
            if (moviesInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            Mapper.Map<MovieDto, Movie>(movieDto, moviesInDb);
            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteMovies(int id)
        {
            var moviesInDb = _context.Movies.Single(c => c.Id == id);
            if (moviesInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Movies.Remove(moviesInDb);
            _context.SaveChanges();
        }
    }
}
