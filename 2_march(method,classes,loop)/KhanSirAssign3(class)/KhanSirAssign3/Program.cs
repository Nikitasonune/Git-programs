using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanSirAssign3
{
    //3.
    class Triangle
     {
         public int side1 = 3;
         public int side2 = 4;
         public int side3=5; 
         //constructor

         public Triangle()
         {

             Console.WriteLine("Area of Triangle is");
             float Area = side1 * side2/2;
             Console.WriteLine("Area of Triangle: " + Area);

             Console.WriteLine("Perimeter of triangle is");
             int Perimeter = side1 + side2 + side3;
             Console.WriteLine("Perimeter of triangle is: " + Perimeter);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             Triangle obj = new Triangle();
             Console.ReadKey();
         }
     }
}
