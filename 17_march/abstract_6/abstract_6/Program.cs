using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_6
{
    abstract class shape
    {
        public abstract void RectangleArea(float length,float breadth);
        public abstract void SquareArea(float side);
        public abstract void CircleArea(double radius);

    }
    class Area:shape
    {
        public override void RectangleArea(float length, float breadth)
        {
            float Area = length * breadth;
            Console.WriteLine("Area of Rectangle: "+Area);
        }
        public override void SquareArea(float side)
        {
            float Area = side * side;
            Console.WriteLine("Area of Square: "+Area);
        }
        public override void CircleArea(double radius)
        {
            
            double Area = 2 * 3.14 * radius * radius;
            Console.WriteLine("Area of Circle: "+Area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area obj = new Area();
            obj.RectangleArea(10,20);
            obj.SquareArea(4);
            obj.CircleArea(3);
            Console.ReadKey();
        }
    }
}
