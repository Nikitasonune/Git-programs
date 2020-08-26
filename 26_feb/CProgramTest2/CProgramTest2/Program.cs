using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProgramTest2
{
    //1.reads an integer and check the specified range where it belongs
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 10)
            {
                Console.WriteLine("number belongs to [0-10] Range: " + num);
            }
            else if (num >= 11 && num <= 30)
            {
                Console.WriteLine("number belongs to [11-30] Range: " + num);
            }
            else if (num >= 31 && num <= 80)
            {
                Console.WriteLine("number belongs to [31-80] Range: " + num);
            }
            else if (num >= 81 && num <= 100)
            {
                Console.WriteLine("number belongs to [81-100] Range: " + num);
            }
            else
            {
                Console.WriteLine("number is greater than 100");
            }
            Console.ReadKey();
        }
    }

}



