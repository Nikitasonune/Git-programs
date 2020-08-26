using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series2_roshanSir
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Geometric series
            int i = 5, num;
             Console.WriteLine("Enter number you want: ");
             num = int.Parse(Console.ReadLine());
             for(i=5;i<= num;i=i*2)
             {

                 Console.WriteLine(i);

             }
        }
    }
}
