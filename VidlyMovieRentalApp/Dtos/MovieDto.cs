using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyMovieRentalApp.Models;

namespace VidlyMovieRentalApp.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public DateTime ReleasedDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
        public byte NumberInStock { get; set; }

        public GenreDto Genre { get; set; }
        public byte GenreId { get; set; }
    }
}