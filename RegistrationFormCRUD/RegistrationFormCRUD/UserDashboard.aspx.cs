using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace RegistrationFormCRUD
{
    public partial class UserDashboard : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection("data source=DESKTOP-J980R18\\SQLEXPRESS;integrated security=true;database=CRUD;");
        string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlDataAdapter da = new SqlDataAdapter("select * from Register", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Register");
            
            Label1.Text = "welcome " + Session["Email"];

            foreach (DataRow dr in ds.Tables["Register"].Rows)
            {
                Label2.Text = dr["FirstName"].ToString() + " "+ dr["MiddleName"].ToString() + dr["LastName"].ToString();
                Label3.Text = dr["MobileNumber"].ToString();
                Label4.Text = dr["Email"].ToString();
                Label5.Text = dr["Gender"].ToString();
                Label6.Text = dr["DateOfBirth"].ToString();
                Label7.Text = dr["Gender"].ToString();
                Label8.Text = dr["CorresAddess"].ToString();
                string image = dr["Photo"].ToString();
                Label9.Text="<center><img src=" + image + " width=100 height=60/></centre>";
            }
        }
    }
}