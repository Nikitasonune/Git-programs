using System;

namespace TestProgram9
{
    //9.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 3: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 < (num2 + num3) && num2 < (num1 + num2) && num3 < (num1 + num2))
            {
                Console.WriteLine("making triangle");
            }
            else
            {
                Console.WriteLine(" Not making triangle");
            }
            Console.ReadKey();
        }
    }
}
