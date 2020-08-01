using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, i;
            Console.WriteLine("Enter number: ");
            i = Convert.ToInt32(Console.ReadLine());
            num1 = 0;
            num2 = 1;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            num3 = 0;
            while (num3<=i) 
            {
                num3 = num1 + num2;
                if (num3<=i)
                {
                    Console.WriteLine(num3);
                }
                num1 = num2;
                num2 = num3;
            }
            Console.ReadKey();
        }
    }
}
