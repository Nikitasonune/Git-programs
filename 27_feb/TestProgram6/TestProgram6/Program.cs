using System;

namespace TestProgram6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.
              string num;
              Console.WriteLine("enter a number: ");
              num = Console.ReadLine();
              //Console.WriteLine(num);
              Console.WriteLine("enter how many times you want to print this number");
              int ch = int.Parse(Console.ReadLine());
              for(int i= 1;i<= ch;i++)
              {
                  Console.WriteLine(num);
              }
        }
    }
}
