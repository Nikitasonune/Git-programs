using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop
            int num, k = 0, i = 1;
            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while(i<=num)
            {
                if(num%i==0)
                {
                    k = k + 1;
                }
                i = i + 1;
            }
            if(k==2)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }


            int m = 0;
            //For loop
            Console.WriteLine("Enter number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for(int n=1;n<=num1;n=n+1)
            {
                if(num1%n==0)
                {
                    m = m + 1;
                }
            }
            if (m == 2)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
        }
    }
}
