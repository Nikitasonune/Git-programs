using System;

namespace TestProgram6
{
    //6.square of even numbers
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1;
            Console.WriteLine("enter number: ");
            num = int.Parse(Console.ReadLine());
            while (i <= num)
            {
                if (i % 2 == 0)
                {
                    int res = i * i;
                    Console.WriteLine("square of " +i + " is: " + res);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
