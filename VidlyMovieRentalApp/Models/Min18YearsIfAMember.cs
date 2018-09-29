using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMovieRentalApp.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        // Note : This class is for the customer validation.
        // When the birthdate is selected customer must be
        // 18 years old 
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == Customer.Unknown || customer.MembershipTypeId == Customer.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required.");
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be atleat 18 years old.");
        }
    }
}