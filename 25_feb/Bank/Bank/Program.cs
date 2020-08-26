using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int ten, twenty, fifty, hundred, five_hundred, two_thousand;
            ten = amount / 10;
            twenty = amount / 20;
            fifty = amount / 50;
            hundred = amount / 100;
            five_hundred = amount / 500;
            two_thousand = amount / 2000;
            Console.WriteLine("ten rupee notes are: " + ten);
            Console.WriteLine("twenty rupee notes are: " + twenty);
            Console.WriteLine("fifty rupee notes are: " + fifty);
            Console.WriteLine("hundred rupee notes are: " + hundred);
            Console.WriteLine("five hundred rupee notes are: " + five_hundred);
            Console.WriteLine("two thousand rupee notes are: " + two_thousand);
            Console.ReadKey();

        }
    }
}
