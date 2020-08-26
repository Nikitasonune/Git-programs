using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_4
{
    abstract class superclass
    {
        public superclass()
        {
            Console.WriteLine("This is abstract class constructor");
        }
        public abstract void a_method();
        public void NonAbstractMethod()
        {
            Console.WriteLine("This is a normal method of abstract class method");
        }
    }
    class subclass:superclass
    {
        public override void a_method()
        {
            Console.WriteLine("This is abstract method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            subclass sb = new subclass();
            sb.a_method();
            sb.NonAbstractMethod();

           
            Console.ReadKey();
            
        }
    }
}
