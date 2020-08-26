using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            /* Console.WriteLine("enter two number: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("the number is in descending order");
            }
           else if (num1<num2)
            {
                Console.WriteLine("the number is in ascending order");
            }
            else if(num1==num2)
            {
                Console.WriteLine("the numbers are equal");
            }*/






            //2.
            /*start:
            int password = 1234;
            Console.WriteLine("Enter password");
            int pass = int.Parse(Console.ReadLine());
            if (pass == password)
            {
                Console.WriteLine("password is correct");
                goto end;
            }
            else if(pass!=password)
            {
                Console.WriteLine("password is incorrect");
                goto start;
            }
            end:*/





            //3.
            /* Console.WriteLine("enter two number: ");
             int num1 = int.Parse(Console.ReadLine());
             int num2 = int.Parse(Console.ReadLine());
             if(num1%num2==0)
             {
                 Console.WriteLine("number is divisible");
             }
             else
             {
                 Console.WriteLine("Division is not possible");
             }*/



            //4.
            /*int i=11,sum=0;
            while(i<=20)
            {
                if(i%17!=0)
                {
                     sum = sum + i;
                }
                i++;
            }
            Console.WriteLine("Sum of all elements that are not divisible by 17 is: "+sum);*/





            //5.
            // int num = 1;
            /* Console.WriteLine("enter number the number you want to start from: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number the number you wanted to end: ");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                if (i % 7 == 2)
                {
                    Console.WriteLine(i);
                }
                else if (i % 7 == 3)
                {
                    Console.WriteLine(i);
                }
                /*else
                {
                    Console.WriteLine("number is divisile by 7");
                }
            }*/



            //6.
            /*  string num;
              Console.WriteLine("enter a number: ");
              num = Console.ReadLine();
              //Console.WriteLine(num);
              Console.WriteLine("enter how many times you want to print this number");
              int ch = int.Parse(Console.ReadLine());
              for(int i= 1;i<= ch;i++)
              {
                  Console.WriteLine(num);
              }*/


            //7.

            /* Console.WriteLine("enter number you want: ");
             int num = int.Parse(Console.ReadLine());
             for (int i = 1; i <= num; i++)
             {
                 Console.WriteLine("the number is: " + i + "  " + i*i + "  " + i*i*i);
             }*/



            //8.
            int p, q;
            Console.WriteLine("enter two number number: ");
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("enter how many times you want to print this number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=num ; i++)
            {
               
                    Console.WriteLine(p + " ");
            }
            Console.ReadKey();
        }
    }
}

