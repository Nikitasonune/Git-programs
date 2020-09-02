using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Student_registeration
{
    public partial class Showlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
con.Open();
            string qr = "select Id,firstname,lastname,mobile,gender,dob,caddress,paddress,stream,course,email,photo,status from student_info";
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_info");
            Response.Write("<h1 align=center >Details of student  </h1><hr>");
            Response.Write("<table width=100% border=1 align=center>");
            Response.Write("<tr>");

            Response.Write("<th>UserId </th>");
            Response.Write("<th>First Name </th>");
            Response.Write("<th>Last Name </th>");
            Response.Write("<th> Mobile No </th>");
            Response.Write("<th>Gender </th>");
            Response.Write("<th>Date of Birth </th>");
            Response.Write("<th>corresspond Address</th>");
            Response.Write("<th>permanent Address </th>");
            Response.Write("<th>stream </th>");
            Response.Write("<th>course </th>");
            Response.Write("<th>Email Id </th>");
           
            Response.Write("<th>Photo </th>");
            Response.Write("<th>Status</th>");

            Response.Write("</tr>");
            foreach (DataRow dr in ds.Tables["student_info"].Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(dr["Id"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["firstname"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["lastname"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["mobile"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["gender"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["dob"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["caddress"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["paddress"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["stream"].ToString());
                Response.Write("</td>");



                Response.Write("<td>");
                Response.Write(dr["course"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["email"].ToString());
                Response.Write("</td>");

               
                Response.Write("<td>");
                Response.Write(dr["photo"].ToString());
               
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["status"].ToString());
                Response.Write("</td>");

                Response.Write("<\tr>");
            }
            Response.Write("</table>");


        }
    }
}