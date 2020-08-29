using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter num2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter num3");
            int num3 = int.Parse(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greatest");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("num2 is greatest");
            }
            else
            {
                Console.WriteLine("num3 is greatest");
            }
            Console.ReadKey();



        }
            

           

    }
}
