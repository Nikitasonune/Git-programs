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
            Console.WriteLine("enter number: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            int year, week, day,month;
            year = Num / 365;
            Console.WriteLine("year is: " + year);
            month = Num / 30;
            Console.WriteLine("month: " + month);
            week = Num / 7;
            Console.WriteLine("week is: " + week);
            day = Num%365 ;
            Console.WriteLine("day is: " + day);

            Console.ReadKey();


        }
    }
}
