using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_assign_from_ques4
{
    //4.
    class Triangle
    {
        //4.oops Assign
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
       
        //constructor

        public Triangle(int a, int b, int c)
        {
            side1 = a;
            side2 = b;
            side3 = c;
           
            int  Area = (side1 * side2) / 2;
            Console.WriteLine("Area of Triangle: " + Area);
            Console.WriteLine();

           
           int Perimeter = side1 + side2 + side3;
            Console.WriteLine("Perimeter of triangle is: " + Perimeter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle obj = new Triangle(3, 4, 5);
            Console.ReadKey();
        }
    }
}
    

