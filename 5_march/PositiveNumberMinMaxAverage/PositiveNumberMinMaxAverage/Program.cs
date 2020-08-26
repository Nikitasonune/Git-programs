using System;

namespace PositiveNumberMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.
            int num = 0, positive = 0, max = 0, min = 0, sum = 0;
            Console.WriteLine("Enter number until it is zero or negative number: ");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                if (num > 0)
                {
                    positive++;
                }
                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());

                if (num > positive)
                {
                    max = num;
                }
                if (num < positive)
                {
                    min = num;
                }
                sum = num + num;
            }
            Console.WriteLine("Total positive numbers are: " + positive);
            Console.WriteLine("Maximun number is: " + max);
            Console.WriteLine("Minimum number is: " + min);
            Console.WriteLine("The sum of numbers are: " + sum);
        }
    }
}
