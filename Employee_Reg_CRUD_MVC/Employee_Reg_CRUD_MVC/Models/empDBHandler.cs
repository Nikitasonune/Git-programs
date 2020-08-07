using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Employee_Reg_CRUD_MVC.Models
{
    public class empDBHandler
    {
        private SqlConnection con;

        public string name { get; private set; }

        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["EmpConString"].ToString();
            con = new SqlConnection(constr);
        }


        //Insert Operation
        public bool InsertItem(EmployeeReg obj)
        {        
                connection();
                
                string query = "insert into Employee_Registeration values('" + obj.name + "','" + obj.email + "','" + obj.password + "','" + obj.gender + "','" + obj.dob + "','" + obj.mobile + "','" + obj.physicalChallenge + "','" + obj.country + "','" + obj.city + "','" + obj.address + "','" + obj.photo + "')";
                SqlCommand cmd = new SqlCommand(query, con);
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
      
        }


        //Read Operation

        public List<EmployeeReg>ReadRecord()
        {
            connection();
            List<EmployeeReg> obj = new List<EmployeeReg>();
           
            string query = "select full_name, email,password,gender,dob,mobile,physical_challenge,country,city,address,photo from Employee_Registeration";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach(DataRow dr in dt.Rows)
            {
                obj.Add(new EmployeeReg
                {
                    //Id = Convert.ToInt32(dr["Id"]),
                    name = Convert.ToString(dr["full_name"]),
                    email = Convert.ToString(dr["email"]),
                    password = Convert.ToString(dr["password"]),
                    gender = Convert.ToString(dr["gender"]),
                    dob = Convert.ToDateTime(dr["dob"]),
                    mobile = Convert.ToString(dr["mobile"]),
                    physicalChallenge = Convert.ToString(dr["physical_challenge"]),
                    country = Convert.ToString(dr["country"]),
                    city = Convert.ToString(dr["city"]),
                    address = Convert.ToString(dr["address"]),
                    photo = Convert.ToString(dr["photo"]),
                });
            }
            return obj;
        }

        internal void updateItem(EmployeeReg obj)
        {
            throw new NotImplementedException();
        }

        internal static bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }



        //Update Operation
        public bool update(EmployeeReg obj)
        {
            connection();
            
            //string query= "update Employee_Registeration set full_name= '"+obj.name+"',password='"+obj.password+"',Gender='"+obj.gender+"',DoB='"+obj.dob+"',mobile='"+obj.mobile+"',physical_challenge='"+obj.physicalChallenge+"',country='"+obj.country+"',city='"+obj.city+"',address='"+obj.address+"',photo='"+obj.photo+"'where Id='"+obj.Id+"'";
            string query = "update Employee_Registeration set password='" + obj.password + "',Gender='" + obj.gender + "',DoB='" + obj.dob + "',mobile='" + obj.mobile + "',physical_challenge='" + obj.physicalChallenge + "',country='" + obj.country + "',city='" + obj.city + "',address='" + obj.address + "',photo='" + obj.photo + "'where full_name='" + obj.name + "'";
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



        //Delete Operation
        public bool DeleteItem(string name)
        {
            connection();
            con.Open();
            string query= "delete from Employee_Registeration where full_name='"+name+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            int i=cmd.ExecuteNonQuery();
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