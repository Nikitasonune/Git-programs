using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace RegistrationFormCRUD
{
    public partial class Login : System.Web.UI.Page
    {
        // SqlConnection con = new SqlConnection("data source=DESKTOP-J980R18\\SQLEXPRESS;integrated security=true;database=CRUD;");
        string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                string email = TextBox1.Text;

                //creating object of PasswordEncryption class and then calling the the method of class
                string pass = PasswordEncryption.encryptPassword(TextBox2.Text);

                con.Open();
                string qr = "select count(*) from TableLogin where EmailID='" + email + "'and Password='" + pass + "'";
                SqlCommand command = new SqlCommand(qr, con);
               // command.ExecuteNonQuery();
                int result = Convert.ToInt32(command.ExecuteScalar());
                if(result==1)
                {
                    Session["Email"] = TextBox1.Text;
                   // Response.Redirect("welcome.aspx");
                    Response.Redirect("UserDashboard.aspx");
                }
                else
                {
                    Label1.Text = "Invalid Credentials";
                }


                
            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }
        }


        
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}