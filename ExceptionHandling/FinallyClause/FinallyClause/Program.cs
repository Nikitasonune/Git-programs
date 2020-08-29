using System;

namespace FinallyClause
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.The finally clause

              decimal num, square;
              try
              {
                  Console.WriteLine("enter number: ");
                  num = Convert.ToDecimal(Console.ReadLine());
                  square = num * num;
                  Console.WriteLine("square is: " + square);
              }
              catch (Exception e)
              {
                  Console.WriteLine(e.ToString());
              }
              finally
              {
                  Console.WriteLine("finally executed");
              }
              Console.ReadKey();
        }
    }
}
