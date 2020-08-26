using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_1
{
    abstract class Parent
    {
        public void Message()
        {
            Console.WriteLine("This is abstract class");
        }
    }
    class one:Parent
    {
        public void Message()
        {
            Console.WriteLine("This is first Subclass");
        }
    }
    class Two:Parent
    {
        public void Message()
        {
            Console.WriteLine("This is second subclass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            one ob1 = new one();
            ob1.Message();      //calling first subclass method

            Two ob2 = new Two();
            ob2.Message();      //calling second subclass method

            Parent p = new one();
            p.Message();        //calling abstract subclass method

            Parent obj = new Two();
            obj.Message();      //calling abstract subclass method



            Console.ReadKey();
        }
    }
}
