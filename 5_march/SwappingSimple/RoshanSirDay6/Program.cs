using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanSirDay6
{
    class Program
    {
        //1.Swapping
        static void Main(string[] args)
        {
             int num1, num2;
             Console.WriteLine("Enter number 1");
             num1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter number 2");
             num2 = int.Parse(Console.ReadLine());

             num1 = num1 + num2;
             num2 = num1 - num2;
             num1 = num1 - num2;

             Console.WriteLine("\nswapping of Numbers");
             Console.WriteLine("\nnumber 1 after swapping is: "+num1);
             Console.WriteLine("number 2 after swapping is: "+num2);


            Console.ReadKey();


        }
    }
}
