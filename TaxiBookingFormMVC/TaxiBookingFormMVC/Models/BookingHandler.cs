using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiBookingFormMVC.Controllers;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TaxiBookingFormMVC.Models
{
    public class BookingHandler
    {
        static string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection con = new SqlConnection(constr);

        //INSERT
        public bool Insert(Booking obj)
        {
            //For Entering checkbox values
            string group = string.Empty;
            foreach(var value in obj.AgeGroup)
            {
                group = group + " " + value.ToString();
            }

            //Actual Insert Query
            string query = "insert into TaxiBooking values('" + obj.Name + "','" + obj.Email + "','" + obj.Contact + "','" + obj.TaxiForDays + "','" + obj.CityLocation + "','" + obj.Date + "','" + obj.PickUpPoint + "','" + obj.DestinationPoint + "','" + obj.NumberOfTraveller + "','" + group + "','" + obj.TaxiType + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}