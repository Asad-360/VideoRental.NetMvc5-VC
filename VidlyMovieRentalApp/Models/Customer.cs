using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMovieRentalApp.Models
{
    public class Customer
    {
        [Display(Name = "Date Of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Customer Name")]
        [StringLength(255)]

        public String Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        // [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}