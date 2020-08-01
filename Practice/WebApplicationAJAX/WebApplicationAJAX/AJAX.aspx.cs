using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationAJAX
{
    public partial class AJAX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TextBox2.Text);
            Label2.Text = "Age is: " + n.ToString();
            Label3.Text=DateTime.Now.ToString();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            long i = 1;
            int n = Convert.ToInt32(TextBox1.Text);
            int r = n * n;
            for (i = 1; i < 10000; i++)
            {

            }
            Label1.Text = "Square of a number is " + r.ToString();
            Response.Write(DateTime.Now.ToString());
        }
    }
}