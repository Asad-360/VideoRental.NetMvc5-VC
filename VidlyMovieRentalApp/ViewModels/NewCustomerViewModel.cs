using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyMovieRentalApp.Models;

namespace VidlyMovieRentalApp.ViewModels
{
    public class NewCustomerViewModel
    {
        public Customer Customer { get; set; }
        [Display(Name = "Membership Type")]
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}