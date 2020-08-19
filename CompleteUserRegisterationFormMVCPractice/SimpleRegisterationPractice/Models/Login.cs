using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleRegisterationPractice.Models
{
    public class Login
    {
        [Display(Name ="Enter Email")]
        [Required(ErrorMessage ="Please enter your Email!")]
        public string UserEmail { get; set; }

        [Display(Name ="Enter Password")]
        [Required(ErrorMessage ="Please enter your Password!")]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Invalid password format Min 7 Characters Maximum 15 Characters")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }


        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("UserPassword")]
        public string Confirm_Password { get; set; }
    }
}