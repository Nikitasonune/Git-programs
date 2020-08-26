using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_7_retype_
{
    abstract class shape
    {
        public float len, brd,sd;
        public double rad;
        public abstract void RectangleArea(float length, float breadth);
        public abstract void SquareArea(float side);
        public abstract void CircleArea(double radius);

    }
    class Area : shape
    {
        public override void RectangleArea(float length, float breadth)
        {
            float Area = length * breadth;
            Console.WriteLine("Area of Rectangle: " + Area);
        }
        public override void SquareArea(float side)
        {
            float Area = side * side;
            Console.WriteLine("Area of Square: " + Area);
        }
        public override void CircleArea(double radius)
        {

            double Area = 2 * 3.14 * radius * radius;
            Console.WriteLine("Area of Circle: " + Area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Area[] obj = new Area[5];
            Console.WriteLine("Rectangle:");
            for (int i = 0; i < 4; i++)
            {
                obj[i] = new Area();

                Console.WriteLine("Enter Length of Rectangle: ");
                obj[i].len = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter breadth of Rectangle: ");
                obj[i].brd = float.Parse(Console.ReadLine());

                obj[i].RectangleArea(obj[i].len,obj[i].brd);
            }

            Console.WriteLine("\nSquare:");
            for (int i = 0; i < 4; i++)
            {
                obj[i] = new Area();

                Console.WriteLine("Enter side of square: ");
                obj[i].sd = float.Parse(Console.ReadLine());

                obj[i].SquareArea(obj[i].sd);
            }
            
            Console.WriteLine("\nCircle:");
            for (int i = 0; i < 5; i++)
            {
                obj[i] = new Area();

                Console.WriteLine("Enter Radius of Circle: ");
                obj[i].rad = float.Parse(Console.ReadLine());

                obj[i].CircleArea(obj[i].rad);
            }
            Console.ReadKey();
        }
    }
}
