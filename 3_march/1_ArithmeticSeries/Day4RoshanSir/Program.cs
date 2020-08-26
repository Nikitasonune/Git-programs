using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4RoshanSir
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //1.Arithmetic series 1,4,7,10,13,16,19......n
            int i = 1,num;
            Console.WriteLine("Enter number you want: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {

                Console.WriteLine(i);
                i = i + 2;
            }
            Console.ReadKey();

        }
    }
}
