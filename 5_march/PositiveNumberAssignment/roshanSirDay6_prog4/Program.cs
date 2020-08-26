using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshanSirDay6_prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.
            int num, rem = 0, sum = 0,num1,num2,num3;
            Console.WriteLine("Enter number any positive number less than 500: ");
            num = int.Parse(Console.ReadLine());        
            if(num<500)
            {
                rem = num % 10;
                num1 = num / 10;
                rem = num % 10;
                num2 = num / 10;
                rem = num % 10;
                num3 = num / 10;

                num1 = num % 10;
                num = num / 10;
                num2 = num % 10;
                num = num / 10;
                num3 = num % 10;
                num = num / 10;

                sum = num1+num2+num3;
            
            }
            Console.WriteLine("the sum of positive number is: " + sum);


            Console.ReadKey();
        }
    }
}
