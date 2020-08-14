using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessRegisterationMVC.Models
{
    public class BusinessModel
    {
        public int Id { get; set; }
        public string Business_Owner { get; set; }
        public string Business_Name { get; set; }
        public string Contact_Number { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Type_Of_Business { get; set; }
        public string Password { get; set; }

    }
}