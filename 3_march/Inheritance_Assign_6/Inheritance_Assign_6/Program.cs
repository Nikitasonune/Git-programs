using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assign_6
{
    //6.
    class Shape
    {
        public void shapemethod()
        {
            Console.WriteLine("This is shape");
        }
    }
    class Rectangle : Shape
    {
        public void rectanglemethod()
        {
            Console.WriteLine("This is Rectangular class");
        }
    }
    class Circle : Shape
    {
        public void circlemethod()
        {
            Console.WriteLine("This is Circular class");
        }
    }
    class Square : Rectangle
    {
        public void squaremethod()
        {
            Console.WriteLine("Square is a rectangle");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Shape s = new Shape();
            Square sq = new Square();
            sq.shapemethod();
            sq.rectanglemethod();
            Console.ReadKey();
        }
    }
}
