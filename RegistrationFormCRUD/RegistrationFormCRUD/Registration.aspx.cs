using System;
using System.Configuration;
using System.Data.SqlClient;

namespace RegistrationFormCRUD
{
    public partial class Registration : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        //SqlConnection con = new SqlConnection("data source=DESKTOP-J980R18\\SQLEXPRESS;integrated security=true;database=CRUD;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);

            string first = TextBox1.Text;
            string middle = TextBox2.Text;
            string last = TextBox3.Text;
            string mobile = TextBox4.Text;
            string email = TextBox5.Text;
            string dateBirth = TextBox6.Text;
            string gender = "";
            if (RadioButton1.Checked)
            {
                gender = RadioButton1.Text;
            }
            else
            {
                gender = RadioButton2.Text;
            }
            string perAddress = TextBox8.Text;
            string corresAddress = TextBox9.Text;
            string state = DropDownList1.Text;
            string city = DropDownList2.Text;
            string pin = TextBox10.Text;
            string streme = "";
            if (RadioButton6.Checked)
            {
                streme = RadioButton6.Text;
            }
            else if (RadioButton7.Checked)
            {
                streme = RadioButton7.Text;
            }
            else
            {
                streme = RadioButton8.Text;
            }
            string course = CheckBoxList1.Text;
            // string photo = FileUpload1.ClientID;


            try
            {
                //string fn1 = "img/" + FileUpload1.FileName;
                string fn = Server.MapPath(FileUpload1.FileName);
                //Response.Write(fn);
                FileUpload1.SaveAs(fn);
                string photo = FileUpload1.FileName;
                con.Open();
                string qr = ("insert into Register values('" + first + "','" + middle + "','" + last + "','" + mobile + "','" + email + "','" + dateBirth + "','" + gender + "','" + perAddress + "','" + corresAddress + "','" + state + "','" + city + "','" + pin + "','" + streme + "','" + course + "','" + photo + "')");
                SqlCommand command = new SqlCommand(qr, con);
                command.ExecuteNonQuery();
                Response.Redirect("CreatePassword.aspx");

            }
            catch (Exception)
            {
                // Label1.Text = ee.ToString();
                Label1.Text = "This Email ID is already registered, please enter another One!";
            }
            finally
            {
                con.Close();
            }
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            // Response.Redirect("Login.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //   Response.Redirect("CreatePassword.aspx");
        }


        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            DateTime dob = Convert.ToDateTime(TextBox6.Text);
            TextBox7.Text = Convert.ToString(calculate_age(dob));
        }


        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {
            // DateTime dob = Convert.ToDateTime(TextBox6.Text);
            // TextBox7.Text = Convert.ToString(calculate_age(dob));
        }
        public int calculate_age(DateTime db)
        {
            int age = 0;
            age = DateTime.Now.Subtract(db).Days;
            age = age / 365;
            return age;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}