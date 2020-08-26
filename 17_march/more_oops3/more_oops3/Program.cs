using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_oops3
{
    class CalculateArea
    {
        public void AreaRectangle(float len,float brd)
        {
            float Area = len * brd;
            Console.WriteLine("The area of Rectangle is: " + Area);
        }
        public void AreaSquare(float side)
        {
            float Area = side * side;
            Console.WriteLine("The area of Square is: " + Area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalculateArea obj = new CalculateArea();

            Console.WriteLine("Enter length and breadth of rectangle: ");
            float length = float.Parse(Console.ReadLine());
            float breadth = float.Parse(Console.ReadLine());
            obj.AreaRectangle(length, breadth);

            Console.WriteLine("\nEnter side of square: ");
            float sd = float.Parse(Console.ReadLine());
            obj.AreaSquare(sd);

            Console.ReadKey();
        }
    }
}
