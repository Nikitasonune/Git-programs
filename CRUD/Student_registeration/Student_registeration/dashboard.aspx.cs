using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace Student_registeration
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "<b><font color=Brown>" + "WELCOME:: " + "</font>" + "<b><font color=red>" + Session["email"] + "</font>";
            string strcon = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string qr = "select firstname,lastname,photo from student_info where email='"+Session["email"]+"'";
            SqlCommand com = new SqlCommand(qr, con);
            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                Image1.ImageUrl = dr["photo"].ToString();
                Label2.Text = dr["firstname"].ToString();
                Label3.Text = dr["lastname"].ToString();
            }
            dr.Close();





        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["email"] = "";
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Register.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
    }
}