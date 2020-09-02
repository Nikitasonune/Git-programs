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
      
    public partial class Register : System.Web.UI.Page
    {
      


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);

            string fname = TextBox1.Text;
            string lname = TextBox2.Text;
            string mobile = TextBox3.Text;
            string gender = "";
            if (RadioButton1.Checked)
            {
                gender = RadioButton1.Text;
                RadioButton2.Visible = false;
                RadioButton3.Visible = false;
            }
            else if (RadioButton2.Checked)
            {
                gender = RadioButton2.Text;
                RadioButton1.Visible = false;
                RadioButton3.Visible = false;
            }
            else if (RadioButton3.Checked)
            {
                gender = RadioButton3.Text;
                RadioButton2.Visible = false;
                RadioButton1.Visible = false;
            }
            string dob = TextBox4.Text;
            String age = TextBox11.Text;
            string c_address = TextBox5.Text;
            string p_address = TextBox6.Text;
            string stream = DropDownList1.Text;
            string course = "";
            if (CheckBox1.Checked)
            {
                course = CheckBox1.Text;
                CheckBox2.Visible = false;
                CheckBox3.Visible = false;
                CheckBox4.Visible = false;

            }
            else if (CheckBox2.Checked)
            {
                course = CheckBox2.Text;
                CheckBox1.Visible = false;
                CheckBox3.Visible = false;
                CheckBox4.Visible = false;
            }
            else if (CheckBox3.Checked)
            {
                course = CheckBox3.Text;
                CheckBox1.Visible = false;
                CheckBox2.Visible = false;
                CheckBox4.Visible = false;

            }
            else if (CheckBox4.Checked)
            {
                course = CheckBox4.Text;
                CheckBox1.Visible = false;
                CheckBox2.Visible = false;
                CheckBox3.Visible = false;

            }
            string email = TextBox7.Text;
            //string pass = TextBox9.Text;
            string pass = Common.Encryptdata(TextBox9.Text);
            string c_pass = TextBox10.Text;
            //string photo = FileUpload1.ClientID;
            string fn = Server.MapPath(FileUpload1.FileName);
            FileUpload1.SaveAs(fn);
            string photo = FileUpload1.FileName;

            string status = "";
            if (CheckBox5.Checked)
            {
                status = "Active";
            }
            else
            {
                status = "not Active";
            }

            try
            {
                con.Open();
                string qr = "select count(*) from student_info where email='" + email + "' ";
                SqlCommand cmd = new SqlCommand(qr, con);
                string result = "";
                int res1 = Convert.ToInt32(cmd.ExecuteScalar());
                if (res1 == 1)
                {
                    TextBox7.Text = "emailid already exist";
                }
                else
                {
                    try
                    {
                      //  con.Open();
                        string qr1 = "insert into student_info values ('" + fname + "','" + lname + "','" + mobile + "','" + gender + "','" + dob + "','" + c_address + "','" + p_address + "','" + stream + "','" + course + "','" + email + "','" + pass + "','" + photo + "','" + status + "')";
                        SqlCommand cmd1 = new SqlCommand(qr1, con);
                        cmd1.ExecuteNonQuery();
                        Label1.Text = "registration successful";

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
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {
                con.Close();

            }
        }
        public int calculate_age(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            return age; 
        }
        //public static string Encryptdata(string password)
        //{
        //    string strmsg = string.Empty;
        //    byte[] encode = new byte[password.Length];
        //    encode = Encoding.UTF8.GetBytes(password);
        //    strmsg = Convert.ToBase64String(encode);
        //    return strmsg;
        //}

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            DateTime dob = Convert.ToDateTime(TextBox4.Text);
            TextBox11.Text = Convert.ToString(calculate_age(dob));
        }
    }
}