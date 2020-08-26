using System;

namespace ReverseProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Reverse
            int num,rev=0,rem;
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());
            while(num!=0)
            {
                rem = num % 10;
                num = num / 10;
                rev = rev * 10 + rem;
            }
            
            Console.WriteLine("Reverse numbers is: " + rev);

        }
    }
}
