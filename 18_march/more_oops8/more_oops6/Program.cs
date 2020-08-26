using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_oops8
{
     class A
    {
        public static void method1()
        {
            Console.WriteLine("Parent");
        }
    }
    class B:A
    {
        public static void method1()
        {
            Console.WriteLine("Child");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            obj1.method1();    //just check error
            //A.method1();

            B obj2 = new B();
            obj2.method1();     //just check error
            B.method1();

            A obj3 = new B();
            obj3.method1();     //just check error

            Console.ReadKey();

        }
    }
}
