using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_Reg_CRUD_MVC.Models
{
    public class EmployeeReg
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public string mobile { get; set; }
        public string physicalChallenge { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string photo { get; set; }

    }
}