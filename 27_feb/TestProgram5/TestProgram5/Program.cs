using System;

namespace TestProgram5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.
            // int num = 1;
             Console.WriteLine("enter number the number you want to start from: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number the number you wanted to end: ");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                if (i % 7 == 2)
                {
                    Console.WriteLine(i);
                }
                else if (i % 7 == 3)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("number is divisile by 7");
                }
            }

        }
    }
}
