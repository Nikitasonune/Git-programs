using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
             try
             {
                 Console.WriteLine("enter a number: ");
                 int i = int.Parse(Console.ReadLine());
                 Console.WriteLine("number is: " + i);
             }
             catch(OverflowException e)
             {
                 Console.WriteLine(e);
             }
             catch(Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             Console.WriteLine("code reached till the end");
             Console.ReadKey();

        }
    }
}
