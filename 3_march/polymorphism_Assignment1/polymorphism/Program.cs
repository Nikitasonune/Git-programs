using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    //creating base class
    class Figure
    {
        public void draw()
        {
            Console.WriteLine("Coiding of figure class draw method");
        }
    }
    class Rectangle : Figure
    {
        //overriding the base class inherited draw method
        public void draw()
        {
            Console.WriteLine("Coiding of Rectangle class draw method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure r = new Rectangle();
            r.draw();
            Console.ReadKey();
        }
    }
}
