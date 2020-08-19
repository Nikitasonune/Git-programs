using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleRegisterationPractice.Models
{
    public class ModelPractice
    {
        [ScaffoldColumn(false)]//is ka matlab hai ye value user se enter nahi hogi form par
        public int UserId { get; set; }

        [DataType(DataType.Text)]      
        [Display(Name ="Full Name")]
        [Required (ErrorMessage ="Please Enter Full Name"),MaxLength(30)]
        public string Full_Name { get; set; }  
        

        [Key]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter Password")]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Invalid password format Min 7 Characters Maximum 15 Characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm_Password { get; set; }

        [Display(Name = "Martial Status")]
        [Required(ErrorMessage = "Please Enter Martial Status")]
        public string Martial_Status { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Please Enter Gender")]
        public string Gender { get; set; }
    }
}