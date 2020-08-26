using System;

namespace Destructor
{
    //Destructor
    class car
    {
        public car()
        {
            Console.WriteLine("Constructor is called");
        }
        ~car()
        {
            Console.WriteLine("Destructor is called");
            Console.ReadKey();
        }
    }
    class Program
    {
        public static void Main()
        {
            car obj = new car();
            Console.ReadKey();
        }
    }
}
