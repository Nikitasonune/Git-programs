using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bhasakars_formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c ");
            int c = int.Parse(Console.ReadLine());

            int result = (b * b) - 4 * a * c;
            if (result > 0)
            {
                Console.WriteLine("the root is: " + Math.Sqrt(result));
            }
            else
            {
                Console.WriteLine("not possible to find the root");
            }
            Console.ReadKey();



        }
    }
}
