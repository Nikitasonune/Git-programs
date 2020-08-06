using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;


namespace RegistrationFormCRUD
{
    
    public partial class CreatePassword : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection("data source=DESKTOP-J980R18\\SQLEXPRESS;integrated security=true;database=CRUD;");
        string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            string email = TextBox3.Text;

            //creating object of PasswordEncryption class and then calling the the method of class
            string pass = PasswordEncryption.encryptPassword(TextBox1.Text);
            string name = TextBox4.Text;

            
            try
            {
                con.Open();

                string query = "select count(*) from TableLogin where EmailID='" + email + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int r = Convert.ToInt32(cmd.ExecuteScalar());
                if(r==0)
                {
                    string qr = "insert into TableLogin values('" + email + "','" + pass + "','" + name + "')";
                    SqlCommand command = new SqlCommand(qr, con);
                    command.ExecuteNonQuery();
                    Label1.Text = "Password Created Successfully";
                }
                else
                {
                    Label1.Text = "Password for this Email ID is already created";
                }
            }
            catch(Exception ee)
            {
                Label1.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }
        }
        //store encrypted password in database 

        /*public string encryptPassword(string pass)
        {
            string msg = "";
            byte[] encode = new byte[pass.Length];
            encode = Encoding.UTF8.GetBytes(pass);
            msg = Convert.ToBase64String(encode);
            return msg;
        }*/

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            //Response.Redirect("Login.aspx");
        }
    }
}