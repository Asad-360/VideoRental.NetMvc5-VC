using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMovieRentalApp.Models;

namespace VidlyMovieRentalApp.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}