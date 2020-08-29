using System;

namespace Basic_C_Sharp
{
    class Program
    { 
            //2.Program
             static void Main(string[] args)
             {
                 string str;
                 Console.WriteLine("Enter your name: ");
                 str = Console.ReadLine();
                 John(str);

                 Console.ReadKey();
             }
             static void John(string str1)
             {
                 Console.WriteLine("welcome Friend: " + str1);
                 Console.WriteLine("Have a nice day!");

             }
        }
    }
