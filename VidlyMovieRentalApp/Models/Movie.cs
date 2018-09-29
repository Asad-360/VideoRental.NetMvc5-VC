using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMovieRentalApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Movie Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(1,20)]
        [Display(Name = "Number In Stock")]
        public byte NumberInStock  { get; set; }
        
        public Genre Genre { get; set; }
        [Required]
        public byte GenreId { get; set; }

    }
}