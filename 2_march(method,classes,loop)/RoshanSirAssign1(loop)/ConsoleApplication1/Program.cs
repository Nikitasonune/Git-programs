using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            float s =0,i;
             for(i=1;i<=50;i++)
              {
                  s = s + 1 / i;
              }
              Console.WriteLine("Result is: " +s);
            Console.ReadKey();

        }
    }
}
