using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanSirAssign4
{
    //4.
    class Triangle
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public int Area { get; set; }
        public int Perimeter { get; set; }
        //constructor

        public Triangle(int Sd1, int Sd2, int Sd3)
        {
            side1 = Sd1;
            side1 = Sd2;
            side3 = Sd3;
        }
        public void getdata()
        {
            Console.WriteLine("Area of Triangle is");
            Area = side1 * side2 / 2;


            Console.WriteLine("Perimeter of triangle is");
            Perimeter = side1 + side2 + side3;

        }
        public void showdata()
        {
            Console.WriteLine("Area of Triangle: " + Area);
            Console.WriteLine("Perimeter of triangle is: " + Perimeter);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle obj = new Triangle(3, 4, 5);
            obj.getdata();
            obj.showdata();
            Console.ReadKey();
        }
    }
}
