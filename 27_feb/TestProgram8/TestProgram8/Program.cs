using System;

namespace TestProgram8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.
            int p, q;
            Console.WriteLine("enter a number: ");
            p = int.Parse(Console.ReadLine());

            Console.WriteLine("enter how many times you want to print this number");
            q = int.Parse(Console.ReadLine());
            for (int i = 1; i <= p; i++)
            {
                int num = 1;
                for (int j = 1; j < p; j++)
                {
                    Console.WriteLine(num);
                    num++;
                }

            }



            Console.ReadKey();
        }
    }
}
    

