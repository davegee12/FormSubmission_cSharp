using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Display(Name = "Your First Name:")]
        [Required]
        [MinLength(4)]
        public string fname{get;set;}

        [Display(Name = "Your Last Name:")]
        [Required]
        [MinLength(4)]
        public string lname{get;set;}

        [Display(Name = "Your Age:")]
        [Required]
        public int age{get;set;}

        [Display(Name = "Your Email:")]
        [Required]
        [EmailAddress]
        public string email{get;set;}

        [Display(Name = "Your Password:")]
        [Required]
        [MinLength(7)]
        [DataType(DataType.Password)]
        public string password{get;set;}
    }
}