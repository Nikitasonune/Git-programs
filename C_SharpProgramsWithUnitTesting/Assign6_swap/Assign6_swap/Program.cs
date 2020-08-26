using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6_swap
{
   public class Program
    {
        //6.Swapping
        static void Main(string[] args)
        {
            int num1, num2,result;
            Console.WriteLine("enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            Program obj = new Program();
            result = obj.swap(num1, num2);
           
            Console.ReadKey();
        }
        public int swap(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("number 1 is: " + a);
            Console.WriteLine("number 2 is: " + b);
            return 0;
        }
    }
}
