using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        //program 1
         static void Main(string[] args)
         {
             welcome obj = new welcome();
             string s1 = "Welcome Friends!";
             string store = obj.method2(s1);
             Console.WriteLine(store);
             Console.ReadKey();
         }
     }
    public class welcome
    {
        public string method2(string s2)
        {
            Console.WriteLine(s2);
            string str = "Have a nice day!";
            return str;

        }
    }
}
