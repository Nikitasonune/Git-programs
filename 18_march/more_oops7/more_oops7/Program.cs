using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_oops7
{
    class One
    {
        public int i=0;
        public void PrintNum()
        {
            Console.WriteLine("The value of i is: " + i);
        }
    }
    class Two:One
    {
        public int j=0;
        public void PrintNum()
        {
            Console.WriteLine("The value of j is: " + j);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Two obj = new Two();
            obj.i = 12;
            obj.j = 10;
            obj.PrintNum();

            
            One obj1 = new One();
            //obj1.i = 12;
            obj1.PrintNum();
            Console.ReadKey();
        }
    }
}
