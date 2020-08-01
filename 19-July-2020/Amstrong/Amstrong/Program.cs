using System;

namespace Amstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem=0,rev=0,org_num;
            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            org_num = num;
            while(num!=0)
            {
                rem = num % 10;
                num = num / 10;
                rev = rev + (rem * rem * rem);
            }
            if(org_num==rev)
            {
                Console.WriteLine("Amstrong");
            }
            else
            {
                Console.WriteLine("Not amstrong");
            }

          
        }
    }
}
