using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_5
{
    //6.
    class Area
    {
        public int length;
        public int breadth;
        public int area=0;

        public void setDim(int len,int brd)
        {
            length = len;
            breadth = brd;
        }
        public int getArea()
        {
            area = length * breadth;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth of rectangle: ");
            int len = int.Parse(Console.ReadLine());
            int brd = int.Parse(Console.ReadLine());

            Area obj = new Area();
            obj.setDim(len,brd);
            int res = obj.getArea();

            Console.WriteLine("Area of Rectangle is: " + res);
            Console.ReadKey();

        }
    }
}
