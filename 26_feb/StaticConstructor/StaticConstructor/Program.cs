using System;

namespace StaticConstructor
{
    //4.Static constructor
    public class Adult
    {
        private static int minimumAge;
        static Adult()
        {
            minimumAge = 18;
        }
        public void showdata()
        {
            Console.WriteLine("age= " + minimumAge);
        }
    }
    class Program
    {
        static void Main(string [] args)
        {
            Adult a = new Adult();
            a.showdata();
            Console.ReadKey();
        }
    }
}
