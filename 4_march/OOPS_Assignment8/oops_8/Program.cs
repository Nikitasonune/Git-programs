using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_8
{
    class Average
    {
        public void calculate(int num1, int num2, int num3)
        {
            int average = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average of three numbers are " + average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            Average obj = new Average();
            obj.calculate(num1, num2, num3);
            Console.ReadKey();
        }
    }
}
