using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingLibrary;
namespace WindowsFormsBanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            double amt = Convert.ToDouble(textBox2.Text);
            string acttype = textBox3.Text;

            if(acttype=="saving")
            {
                act = new Saving();
            }
            else if(acttype=="current")
            {
                act = new Current();
            }
            else
            {
                MessageBox.Show("Enter saving or current");
                textBox3.Clear();
                textBox3.Focus();
            }
            if(act!=null)
            {
                act.AccountNumber = actno;
                string result = act.Deposit(amt);
                label4.Text = result;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Account act = null;
            if (act!= null)
            {
                string result = act.showBalance();
                label4.Text = result;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Balance = 1000;
            Account act = null;
            
            int actno = Convert.ToInt32(textBox1.Text);
            double amt = Convert.ToDouble(textBox2.Text);
            string acttype = textBox3.Text;

            if (acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "current")
            {
                act = new Current();
            }
            else
            {
                MessageBox.Show("Enter saving or current");
                textBox3.Clear();
                textBox3.Focus();
            }
            if (amt > Balance)
            {
                MessageBox.Show("Invalid amount");
                textBox2.Clear();
                textBox2.Focus();  
            }
           else if (act != null)
            {
                act.AccountNumber = actno;
                string result = act.withdrawal(amt);
                label4.Text = result;
            }
           
        }
    }
}
