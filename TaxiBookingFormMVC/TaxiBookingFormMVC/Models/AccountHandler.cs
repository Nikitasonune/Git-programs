using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiBookingFormMVC.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace TaxiBookingFormMVC.Models
{
    public class AccountHandler
    {
        static string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection con = new SqlConnection(constr);


        //INSERT
       /* public bool Insert(AccountRegisteration obj)
        {
            string query = "insert into TaxiLoginRegisteration(fullname,email,mobile,password)values('" + obj.FullName + "','" + obj.Email + "','" + obj.Mobile + "','" + obj.Password + "')";
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
            
        }*/


        //READ (Disply All Record in Admin Dashobard only)
       /* public List<AccountRegisteration>Read()
        {
            List<AccountRegisteration> obj = new List<AccountRegisteration>();
            string query = "select userid,fullname,email,mobile,password from TaxiLoginRegisteration";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            apt.Fill(dt);
            con.Close();
            foreach(DataRow dr in dt.Rows)
            {
                obj.Add(new AccountRegisteration
                {
                    UserId = Convert.ToInt32(dr["userid"]),
                    FullName = Convert.ToString(dr["fullname"]),
                    Email = Convert.ToString(dr["email"]),
                    Mobile = Convert.ToString(dr["mobile"]),
                    Password = Convert.ToString(dr["password"]),
                });
            }
            return obj;
        }*/




        //EDIT Record

        public bool Update(AccountRegisteration ac)
        {
            string query = "update TaxiLoginRegisteration set fullname='" + ac.FullName + "',mobile='" + ac.Mobile + "',password='" + ac.Password + "' where email='" + ac.Email + "'";
            SqlCommand cmd = new SqlCommand(query,con);
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

        internal bool DeleteRecord(int id)
        {
            throw new NotImplementedException();
        }
        /*
        internal bool DeleteRecord(string fullname)
        {
            throw new NotImplementedException();
        }

    */

        //DELETE
        public bool DeleteRecord(string Email)
        {
            string query = "delete from TaxiLoginRegisteration where email='" + Email + "'";
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