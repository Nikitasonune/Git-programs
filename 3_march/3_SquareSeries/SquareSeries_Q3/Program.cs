using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSeries_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.square series
            int i = 1, num;
            Console.WriteLine("Enter number you want: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                Console.WriteLine(i*i);
            }
        }
    }
}
