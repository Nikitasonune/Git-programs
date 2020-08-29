using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BasicMaths
    {
        public double Add(double num1,double num2)
        {
            return num1 + num2;
        }
        public double subtract(double num1,double num2)

        {
            return num1 - num2;
        }
        public double divide(double num1,double num2)
        {
            return num1 / num2;
        }    
        public double multiply(double num1,double num2)
        {
            return num1 * num2;
        }
        static void Main(string[] args)
        {
            BasicMaths bm = new BasicMaths();
            Console.WriteLine("enter 2num");
            double n1 = Convert.ToInt32(Console.ReadLine());
            double n2 = Convert.ToInt32(Console.ReadLine());
            double res = bm.Add(n1, n2);
            Console.WriteLine("Add=" + res);
        }
    }
}
