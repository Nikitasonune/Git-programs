using System;

namespace SumOfPositiveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem = 0, rev = 0, sum = 0;
            Console.WriteLine("Enter number any positive number less than 500: ");
            num = int.Parse(Console.ReadLine());
            //int org_num = num;
            for (int i = 1; i <= 500; i++)
            {
                rem = num % 10;
                num = num / 10;
                sum = rem + num;
                Console.WriteLine("the sum of positive number is: " + num + sum);

            }
            Console.WriteLine(sum);

            Console.ReadKey();
        }

    }
}

