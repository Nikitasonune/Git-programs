using System;

namespace MinMaxNumberDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.
            int min, max;
            Console.WriteLine("enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number 4: ");
            int num4 = int.Parse(Console.ReadLine());

            if(num1>num2 && num1>num3 && num1>num4)
            {
                max = num1;
            }
           else if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                max = num2;
            }
           else if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                max = num3;
            }
            else 
            {
                max = num4;
            }
            Console.WriteLine("The Maximum number is: " + max);


            if (num1 < num2 && num1 < num3 && num1 < num4)
            {
                min = num1;
            }
            else if (num2 < num1 && num2 < num3 && num2 < num4)
            {
                min = num2;
            }
            else if (num3 < num1 && num3 < num2 && num3 < num4)
            {
                min = num3;
            }
            else
            {
                min = num4;
            }
            Console.WriteLine("The Minimum number is: " + min);
            int res= max - min;
            Console.WriteLine("The difference of Maximum and minimum number is: " +res);
        }
    }
}
