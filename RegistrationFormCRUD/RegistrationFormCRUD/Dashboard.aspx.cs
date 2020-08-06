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
    public partial class Dashboard : System.Web.UI.Page
    {
        //SqlConnection con=new SqlConnection("data source=DESKTOP-J980R18\\SQLEXPRESS;integrated security=true;database=CRUD;");
        string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //Read Operation
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlDataAdapter da = new SqlDataAdapter("select * from Register", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Register");

            //Displaying Record in Table

            Response.Write("<h1 align=center>Details Of Students</h1><hr>");
            Response.Write("<table width=70% border=1 align=center>");
            Response.Write("<tr>");
            Response.Write("<th>User ID</th>");
            Response.Write("<th>First Name</th>");
            Response.Write("<th>Middle Name</th>");
            Response.Write("<th>Last Name</th>");
            Response.Write("<th>Mobile Number</th>");
            Response.Write("<th>Email Id</th>");
            Response.Write("<th>DOB</th>");
            Response.Write("<th>Gender</th>");
            Response.Write("<th>Permanent Address</th>");
            Response.Write("<th>Correspondane Address</th>");
            Response.Write("<th>State</th>");
            Response.Write("<th>City</th>");
            Response.Write("<th>PIN Number</th>");
            Response.Write("<th>Streme</th>");
            Response.Write("<th>Course</th>");
            Response.Write("<th>Photo</th>");
            Response.Write("<th>Button</th>");
            Response.Write("</tr>");

            foreach (DataRow dr in ds.Tables["Register"].Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(Convert.ToInt32(dr["UserID"]));
                Response.Write("</td>");

                //Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["FirstName"].ToString());
                Response.Write("</td>");

               // Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["MiddleName"].ToString());
                Response.Write("</td>");

                //Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["LastName"].ToString());
                Response.Write("</td>");

                // Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["MobileNumber"].ToString());
                Response.Write("</td>");

                // Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["Email"].ToString());
                Response.Write("</td>");

                // Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["DateOfBirth"].ToString());
                Response.Write("</td>");

                //  Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["Gender"].ToString());
                Response.Write("</td>");

                // Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["permanentAddress"].ToString());
                Response.Write("</td>");

                // Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["CorresAddess"].ToString());
                Response.Write("</td>");

                //Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["State"].ToString());
                Response.Write("</td>");

                //Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["City"].ToString());
                Response.Write("</td>");

                // Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["Pin"].ToString());
                Response.Write("</td>");

                // Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["Streme"].ToString());
                Response.Write("</td>");

                // Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["Course"].ToString());
                Response.Write("</td>");

                // Response.Write("<tr>");
                Response.Write("<td>");
                string image = dr["Photo"].ToString();
                Response.Write("<center><img src=" + image + " width=100 height=60/></centre>");
                Response.Write("</td>");

                Response.Write("<td>");
                Button myButton = (Button)FindControl("Update");
                Response.Write("</td>");

                Response.Write("</tr>");
               
            }
            Response.Write("</table>");

        }
    }
}