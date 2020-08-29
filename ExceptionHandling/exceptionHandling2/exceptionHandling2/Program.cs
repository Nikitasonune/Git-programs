using System;

namespace exceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Program
            try
            {
                Console.WriteLine("enter first number: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("enter second number: ");
                int j = int.Parse(Console.ReadLine());
                int k = i / j;
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("code reached till the end");
            Console.ReadKey();
        }
    }
}
