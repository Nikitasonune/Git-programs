using System;

namespace TestProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            start:
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
        end:;
        }
    }
}
