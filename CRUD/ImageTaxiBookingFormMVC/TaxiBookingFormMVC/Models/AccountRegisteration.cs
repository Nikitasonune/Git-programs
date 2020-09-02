using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TaxiBookingFormMVC.Models
{
    public class AccountRegisteration
    {
        internal static string image;

        public AccountRegisteration()
        {
            UserImage = null;//First null the image value
        }

        public int UserId { get; set; }

        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Please enter your Full Name Please!")]
        [DataType(DataType.Text)]
        public string FullName { get; set; }


        [Key]
        [Display(Name = "Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "Please enter your Email Address Please!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }



        [Display(Name ="Contact Number")]
        [Required(ErrorMessage ="Please enter your Contact Number Please!"),MinLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }



        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter your Password Please!")]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Invalid password format Min 7 Characters Maximum 15 Characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please enter Confirm Password Please!")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


        public byte[] UserImage { get; set; }
        
        
    }
}