using System;

namespace ConstructorPractice
{
    //8.
    public class Adult
    {
        static int minimumage;
        static Adult()
        {
            minimumage = 18;
        }
        public void showdata()
        {
            Console.WriteLine("age= " + minimumage);
        }

    }
    class Program
    {
        static void Main(string[] ags)
        {
            Adult a = new Adult();
            a.showdata();
            Console.WriteLine(Adult.minimumage);//Check Error here
            Console.ReadKey();
        }
    }

}
