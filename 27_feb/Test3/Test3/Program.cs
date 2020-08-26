using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        //1.
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("the number is in descending order");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("the number is in ascending order");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("the numbers are equal");
            }

        }
    }     
}
