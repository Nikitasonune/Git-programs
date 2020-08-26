using System;

namespace TestProgram4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.
            int i=11,sum=0;
            while(i<=20)
            {
                if(i%17!=0)
                {
                     sum = sum + i;
                }
                i++;
            }
            Console.WriteLine("Sum of all elements that are not divisible by 17 is: "+sum);
        }
    }
}
