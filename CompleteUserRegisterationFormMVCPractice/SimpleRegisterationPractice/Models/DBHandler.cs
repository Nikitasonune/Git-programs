using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SimpleRegisterationPractice.Models
{
    public class DBHandler
    {
        static string constr = ConfigurationManager.ConnectionStrings["conString"].ToString();
        SqlConnection con = new SqlConnection(constr);


        //INSERT
        public bool Insert(ModelPractice mp)
        {
            string query = "insert into SimpleRegisteration(Full_Name,Email,Password,Martial_Status,Gender)values('" + mp.Full_Name + "','" + mp.Email + "','" + mp.Password + "','" + mp.Martial_Status + "','" + mp.Gender + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
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


        //READ
        public List<ModelPractice>Read()
        {
            List<ModelPractice> ob = new List<ModelPractice>();
            string query = "select UserId,Full_Name,Email,Password,Martial_Status,Gender from SimpleRegisteration";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                ob.Add(new ModelPractice
                {
                    UserId = Convert.ToInt32(dr["UserId"]),
                    Full_Name = Convert.ToString(dr["Full_Name"]),
                    Email = Convert.ToString(dr["Email"]),
                    Password = Convert.ToString(dr["Password"]),
                    Martial_Status = Convert.ToString(dr["Martial_Status"]),
                    Gender = Convert.ToString(dr["Gender"])
                });
            }
            return ob;
        }
            


        //UPDATE
        public bool Edit(ModelPractice mp)
        {
            string query = "update SimpleRegisteration set Full_Name='" + mp.Full_Name + "',Password='" + mp.Password + "',Martial_Status='" + mp.Martial_Status + "',Gender='" + mp.Gender + "' where Email='" + mp.Email + "'";
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



        //DELETE
        public bool DeleteRecord(string Full_Name)
        {
            string query = "delete from SimpleRegisteration where Full_Name='" + Full_Name + "'";
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


        //change password method
       /* public bool forgetPass(Login obj)
        {
            string qr = "update SimpleRegisteration set Password='" + obj.UserPassword + "' where Email='" + obj.UserEmail + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }*/


    }
}