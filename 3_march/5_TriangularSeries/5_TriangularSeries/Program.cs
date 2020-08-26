using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_TriangularSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Triangular series
             int i, num,sum=0;
             Console.WriteLine("Enter number you want: ");
             num = int.Parse(Console.ReadLine());
             for (i = 1; i <= num; i++)
             {
                 sum = sum + i;
                 Console.WriteLine(sum);
             }
        }
    }
}
