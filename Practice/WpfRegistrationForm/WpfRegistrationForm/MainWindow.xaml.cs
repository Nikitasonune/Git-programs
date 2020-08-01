using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfRegistrationForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            

            MessageBox.Show("Registration successfull ");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            textBox1.Clear();
            comboBox1.SelectedItem = "";
            textBox2.Clear();
            textBox3.Clear();
            radioButton.IsChecked = null;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
            StringBuilder Sb = new StringBuilder();
            Sb.Append("Name: " + textBox.Text + "\n");
            Sb.Append("Email: " + textBox1.Text + "\n");
            Sb.Append("City: " + comboBox1.SelectionBoxItem.ToString() + "\n");
            Sb.Append("Address: " + textBox2.Text + "\n");
            Sb.Append("Phone: " + textBox3.Text + "\n");
            if((bool)radioButton.IsChecked)
            {
                Sb.Append("Gender: " + radioButton.Content + "\n");
            }
            else
            {
                Sb.Append("Gender: " + radioButton1.Content+ "\n");
            }
            label6.Content = Sb.ToString();


        }
    }
}
