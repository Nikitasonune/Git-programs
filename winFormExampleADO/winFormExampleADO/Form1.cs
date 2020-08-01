using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace winFormExampleADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=e:\\MKDB1.accdb;");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int roll = Convert.ToInt32(textBox1.Text);
                string name = textBox2.Text;
                string sub = textBox3.Text;
                string qr="insert into Student values("+roll+",'" +name+ "','"+sub+"')";
                OleDbCommand command = new OleDbCommand(qr, con);
                command.ExecuteNonQuery();
                label4.Text="Record saved successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch(Exception ee)
            {
                label4.Text = ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
