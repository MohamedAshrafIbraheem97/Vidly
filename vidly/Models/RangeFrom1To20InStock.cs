using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace vidly.Models
{
    public class RangeFrom1To20InStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;

            return (movie.NumberInStock >= 1 && movie.NumberInStock <= 20)
                ? ValidationResult.Success
                : new ValidationResult("The Field Number In Stock Must be Between 1 and 20");
        }
    }
}