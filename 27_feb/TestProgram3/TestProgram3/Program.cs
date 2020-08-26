using System;

namespace TestProgram3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.
             Console.WriteLine("enter two number: ");
             int num1 = int.Parse(Console.ReadLine());
             int num2 = int.Parse(Console.ReadLine());
             if(num1%num2==0)
             {
                 Console.WriteLine("number is divisible");
             }
             else
             {
                 Console.WriteLine("Division is not possible");
             }
        }
    }
}
