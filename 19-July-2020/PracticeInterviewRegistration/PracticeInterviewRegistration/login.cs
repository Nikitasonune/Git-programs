using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticeInterviewRegistration
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-J980R18\\SQLEXPRESS; integrated security=true; database=ProjectDB");
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                string em = textBox1.Text;
                string pass = textBox2.Text;
                string result ="";
                string qr = "select count(*) from RegPractice where email='" + em + "'and password='" + pass + "'";
                SqlCommand command = new SqlCommand(qr, con);
                int r = Convert.ToInt32(command.ExecuteScalar());
                Dashboard obj = new Dashboard();
                if (r==1)
                {
                    result = "true";
                    obj.Show();
                }

                else
                {
                    result = "false";
                    MessageBox.Show("Invalid Credentials");
                }

                //MessageBox.Show("Login Successfull");
               
                
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
           
            
        }
    }
}
