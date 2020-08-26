using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_oops1
{
    class PrintNumber
    {
        public void printn(int num1)
        {
            Console.WriteLine("The integer datatype: " + num1);

        }
        public void printn(double num2)
        {
            Console.WriteLine("The float datatype: " + num2);

        }
        public void printn(string num3)
        {
            Console.WriteLine("The String datatype: " + num3);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumber PN = new PrintNumber();
            PN.printn(10);
            PN.printn(10.4);
            PN.printn("Nikita");
            Console.ReadKey();

        }
    }
}
