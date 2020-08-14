using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BusinessRegisterationMVC.Models
{
    public class DB_Handler
    {
        static string conStr = ConfigurationManager.ConnectionStrings["conString"].ToString();
        SqlConnection con = new SqlConnection(conStr);



        //INSERT OPERATION********
        public bool Insert(BusinessModel obj)
        {
            con.Open();
            string query = "insert into Business_Registeration values('" + obj.Business_Owner + "','" + obj.Business_Name + "','" + obj.Contact_Number + "','" + obj.Email + "','" + obj.Address + "','" + obj.Type_Of_Business + "','" + obj.Password + "')";
            SqlCommand cmd = new SqlCommand(query, con);
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



        //READ OPERATION***************
        public List<BusinessModel> Read()
        {
            con.Open();
            List<BusinessModel> obj12 = new List<BusinessModel>();
            string query = "select Id,Business_Owner,Business_Name,Contact_Number,Email,Address,Type_Of_Business,Password from Business_Registeration";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            foreach(DataRow dr in dt.Rows)
            {
                obj12.Add(new BusinessModel
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Business_Owner = Convert.ToString(dr["Business_Owner"]),
                    Business_Name = Convert.ToString(dr["Business_Name"]),
                    Contact_Number = Convert.ToString(dr["Contact_Number"]),
                    Email = Convert.ToString(dr["Email"]),
                    Address = Convert.ToString(dr["Address"]),
                    Type_Of_Business = Convert.ToString(dr["Type_Of_Business"]),
                    Password = Convert.ToString(dr["Password"]),
                });
            }
            return obj12;
        }




        //UPDATE*****
        public bool Update(BusinessModel obj13)
        {
            con.Open();
            string query = "update Business_Registeration set Business_Owner='" + obj13.Business_Owner + "',Business_Name='" + obj13.Business_Name + "',Contact_Number='" + obj13.Contact_Number + "',Address='" + obj13.Address + "',Type_Of_Business='" + obj13.Type_Of_Business + "',Password='" + obj13.Password + "' where Email='" + obj13.Email + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
            

        //DELETE************
        public bool Delete(string Email)
        {
            con.Open();
            string query = "delete from Business_Registeration where Email='" + Email + "'";
            SqlCommand cmd = new SqlCommand(query, con);
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