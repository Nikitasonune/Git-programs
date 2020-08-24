using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TaxiBookingFormMVC.Models
{
    public class Booking
    {
        public int UserId { get; set; }

        [Display(Name ="Your Name")]
        [Required(ErrorMessage ="Please enter your Name"),MaxLength(30)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Key]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter your Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Please enter your Contact Number with Maximum 10 Digits"), MaxLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string Contact { get; set; }

        [Display(Name = "Taxi For")]
        [Required(ErrorMessage = "Please select valid type")]
        public string TaxiForDays { get; set; }//RadioButton

        [Display(Name = "City Location")]
        [Required(ErrorMessage = "Please select City location")]
        public string CityLocation { get; set; }//RadioButton

        [Display(Name = "Booking Date")]
        [Required(ErrorMessage = "Please select Booking Date")]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Display(Name = "Pick Up Point")]
        [Required(ErrorMessage = "Please enter Pick Up Point")]
        [DataType(DataType.Text)]
        public string PickUpPoint { get; set; }

        [Display(Name = "Pick Deatination Point")]
        [Required(ErrorMessage = "Please enter Deatination Point")]
        [DataType(DataType.Text)]
        public string DestinationPoint { get; set; }

        [Display(Name = "Number of Travellers")]
        [Required(ErrorMessage = "Please enter Numbers of Travellers")]
        [DataType(DataType.Text)]
        public string NumberOfTraveller { get; set; }//RadioButton

        [Display(Name = "Citizen Type")]
        [Required(ErrorMessage = "Please select Citizen Type")]
        public string AgeGroup { get; set; }//checkBox

        [Display(Name = "Taxi Type")]
        [Required(ErrorMessage = "Please select Taxi Type")]
        public string TaxiType { get; set; }//DropdownList
    }
}