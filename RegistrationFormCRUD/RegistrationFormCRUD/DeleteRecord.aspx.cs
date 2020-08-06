using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace RegistrationFormCRUD
{ 
    public partial class ShowRecord : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-J980R18\\SQLEXPRESS;integrated security=true;database=CRUD;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fn =TextBox1.Text;
            string ln = TextBox2.Text;
            string mn = TextBox1.Text + TextBox2.Text;

            try
            {
                con.Open();
                string qr ="DELETE FROM tblL FROM TableLogin AS tblL INNER JOIN Register AS reg ON tblL.EmailID = reg.Email WHERE FirstName ='"+fn+"',LastName = '"+ln+"' DELETE FROM reg FROM Register AS reg WHERE FirstName = '"+fn+"',LastName = '"+ln+"'";
               // string qr = "DELETE FROM tblL FROM TableLogin AS tblL INNER JOIN Register AS reg ON tblL.EmailID = reg.Email WHERE FullName ='" + mn + "' DELETE FROM reg FROM Register AS reg WHERE FirstName = '" + fn + "',LastName = '" + ln + "'";
                SqlCommand command = new SqlCommand(qr, con);
                command.ExecuteNonQuery();
                Label1.Text = "Record Deleted Successfully";
            }
            catch(Exception ee)
            {
                //Label1.Text = "Please Enter Valid User ID";
                Label1.Text = ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}