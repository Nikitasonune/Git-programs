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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-J980R18\\SQLEXPRESS; integrated security=true; database=ProjectDB");
        public Form1()
        {
            InitializeComponent();
        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string name = textBox1.Text;
                string add = textBox2.Text;
                string city = comboBox1.Text;
                string g = "";
                if(radioButton1.Checked)
                {
                    g = radioButton1.Text;
                }
                else
                {
                    g = radioButton2.Text;
                }
                string email = textBox3.Text;
                string pass = textBox4.Text;
                string sub = "";
                if(checkBox1.Checked)
                {
                     sub = checkBox1.Text;
                }
                else if(checkBox2.Checked)
                {
                     sub = checkBox2.Text;
                }
                else
                {
                     sub = checkBox3.Text;
                }
                string qr = "insert into RegPractice values('" + name + "','" + add + "','" + city + "','" + g + "','" + email + "','" + pass + "','" + sub + "')";
                SqlCommand command = new SqlCommand(qr, con);
                command.ExecuteNonQuery();
                MessageBox.Show ("Registration Successfull");
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login obj = new login();
            //this.Close();           
            obj.Show();
            Visible = false;
        }
    }
}
