using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;


namespace Student_registeration
{
    public partial class Login : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
            protected void Button1_Click(object sender, EventArgs e)
        {
            string strconv = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(strconv);

            string em = TextBox1.Text;
            string password = Common.Encryptdata(TextBox2.Text);
            try
                {
                    con.Open();
                    string qr = "select count(*) from student_info where email='" + em + "' and password = '" + password + "'";
                    SqlCommand cmd = new SqlCommand(qr, con);
                    int res = Convert.ToInt32(cmd.ExecuteScalar());
                    if (res == 1)
                    {
                    Session["email"] = em;
                    Response.Redirect("dashboard.aspx");
                    }
                    else
                    {
                        Label1.Text = "invalid credential";
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
        }
       
    }
