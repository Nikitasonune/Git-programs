using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myLibrary;

namespace Add_SubDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();

            Console.WriteLine("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = c.Addittion(num1, num2);
            Console.WriteLine("Addittion is: " + result);

            result = c.Substraction(num1, num2);
            Console.WriteLine("Substraction is: " + result);
            Console.ReadKey();
        }
    }
}
