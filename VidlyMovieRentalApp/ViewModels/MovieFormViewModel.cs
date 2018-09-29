using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyMovieRentalApp.Models;

namespace VidlyMovieRentalApp.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
            Id = movie.Id;
        }

        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please Enter Movie Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime? ReleasedDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number In Stock")]
        public byte? NumberInStock { get; set; }

        [Required] public byte? GenreId { get; set; }


        public string Title
        {
            get { return Id != 0  ? "Edit Movie" : "New Movie"; }
        }
    }
}