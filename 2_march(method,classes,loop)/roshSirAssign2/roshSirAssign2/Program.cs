using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshSirAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            float s = 0, j = 2, i=3;
            s = s + 1;
            while(i<=8)
             {

                 s = s + (i / j);
                 i = i + 2;
                 j = j * 2;

             }

             Console.WriteLine("Result is: " + s);
             Console.ReadKey();
        }
    }
}
