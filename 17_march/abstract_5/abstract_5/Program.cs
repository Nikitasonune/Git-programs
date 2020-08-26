using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_5
{
    abstract class Animal
    {
        public abstract void cats();
        public abstract void dogs();
    }
    class Cat:Animal
    {
        public override void cats() //Thid method is called at runtime
        {
            Console.WriteLine("Cats Meow (Cats class method)");
        }
        public override void dogs()
        {
            Console.WriteLine("Dogs Bark (Cats class method)");
        }
    }
    class Dog:Animal
    {
        public override void cats() 
        {
            Console.WriteLine("Cats Meow (Dogs class method)");
        }
        public override void dogs()     //this method is called at runtime
        {
            Console.WriteLine("Dogs Bark (Dogs class method)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.cats();           //calling Cat class cat method
            Dog d = new Dog();
            d.dogs();           //calling Dog class dog method
            Console.ReadKey();
        }
    }
}
