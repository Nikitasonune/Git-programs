using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Collection_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ht = new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
             ht.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICollection key = ht.Keys;
            StringBuilder sb = new StringBuilder();
            foreach( string k in key)
            {
                sb.Append(k + ":" + ht[k] + "\n");
            }
            label4.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ht.ContainsKey(textBox1.Text))
            {
                MessageBox.Show("The student is already in the list");
                label4.Text = "phone no: " + ht[textBox1.Text].ToString();
            }
            else
            {
                label4.Text = "record does not exist in collection";
            }
        }
    }
}
