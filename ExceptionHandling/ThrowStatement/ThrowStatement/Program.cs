using System;

namespace ThrowStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Throw statement
            int minute;
            try
            {
                Console.WriteLine("enter minute: ");
                minute = int.Parse(Console.ReadLine());
                if (minute <= 1 || minute >= 60)
                {
                    throw new Exception(minute + " is not a valid minute");
                }
                Console.WriteLine("minute is " + minute);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
