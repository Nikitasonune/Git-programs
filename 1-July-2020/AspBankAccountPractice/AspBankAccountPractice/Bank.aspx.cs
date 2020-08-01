using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspBankAccountPractice
{
    public partial class Bank : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal balance = 2000;
            string name = TextBox1.Text;
            decimal Amount = Convert.ToDecimal(TextBox2.Text);
            balance = balance + Amount;
            Label3.Text=("Amount deposited successfully, Available balance is "+balance);
            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            decimal balance = 2000;
            string name = TextBox1.Text;
            decimal Amount = Convert.ToDecimal(TextBox2.Text);
            balance = balance - Amount;
            Label3.Text = ("Amount withdrawal successfully, Available balance is " + balance);
        }
    }
}