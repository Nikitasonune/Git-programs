using System;

namespace TestProgram3
{
    //3.reads two integer and check if they are multiplied or not
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp,sum=0,res,i=1;
            Console.WriteLine("enter number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine(num1 +" is multiplied by " +num2);
                }
                else
                {
                    Console.WriteLine(num1 + " is not multiplied by " +num2);

                }
            }
            
            if (num2 > num1)
            {
                Console.WriteLine(num1 + " is samaller than "+num2);
                Console.WriteLine("do swapping");
                temp = num1;
                num1 = num2;
                num2 = temp;
                Console.WriteLine("number 1 is="+num1);
                Console.WriteLine("number 2 is=" + num2);
                if (num1 % num2 == 0)
                {
                    Console.WriteLine(num1 + " is multiplied by " + num2);
                }
                else
                {
                    Console.WriteLine(num1 + "  not multiplied by " + num2);

                }
            }

            Console.ReadKey();
        }
    }
}
