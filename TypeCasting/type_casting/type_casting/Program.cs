using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Data type conversion
            int intvalue = 123;
            long longvalue = intvalue;
            Console.WriteLine("(long){0}={1}",intvalue, longvalue);
            Console.ReadKey();

        }
    }
}
