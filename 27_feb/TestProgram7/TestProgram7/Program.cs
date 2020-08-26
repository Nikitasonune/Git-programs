using System;

namespace TestProgram7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.

             Console.WriteLine("enter number you want: ");
             int num = int.Parse(Console.ReadLine());
             for (int i = 1; i <= num; i++)
             {
                 Console.WriteLine("the number is: " + i + "  " + i*i + "  " + i*i*i);
             }
        }
    }
}
