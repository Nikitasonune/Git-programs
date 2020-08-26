using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assign_5
{
    //5.
    class Rectangle
     {
         public int length;
         public int breadth;
         public Rectangle()
         {
             Console.WriteLine("default constructor");
         }
         public Rectangle(int len, int brd)
         {
             length = len;
             breadth = brd;
         }
         public void area()
         {
             int Area = length * breadth;
             Console.WriteLine("Area of Rectangle is: " + Area);
         }
         public void Perimeter()
         {
             int Perimeter = length + breadth/2;
             Console.WriteLine("Area of Rectangle is: " + Perimeter);
         }
     }
     class Square : Rectangle
     {
         public int side;
         public Square(int sq)
         {
             side = sq;

         }
         public void area()
         {
             int Area = side * side;
             Console.WriteLine("Area of Square is: " + Area);
         }
         public void Perimeter()
         {
             float Perimeter = 4 * side;
             Console.WriteLine("Area of Square is: " + Perimeter);
         }
     }
     class Program
     {

         static void Main(string[] args)
         {
             Rectangle R = new Rectangle(5, 10);
             R.area();
             R.Perimeter();


             Square[] s = new Square[10];
             for (int i=1;i<10;i++)
             {
                 Console.WriteLine("Enter side of square: ");
                 int num = int.Parse(Console.ReadLine());
                 s[i] = new Square(num);
                 s[i].area();
                 s[i].Perimeter();
             }   
             Console.ReadKey();
         }
     }
}
