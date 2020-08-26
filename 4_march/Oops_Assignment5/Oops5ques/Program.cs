using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops5ques
{
    //5.
    class Rectangle
    {
        public int length;
        public int breadth;
        
        public Rectangle(int len, int brd)
        {
            length = len;
            breadth = brd;
        }
        public string area()
        {
            int Area = length * breadth;
            Console.WriteLine("area of Rectangle is: " + Area);
            return "area of Rectangle is " + Area + " of length and breadth: " + length + breadth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r = new Rectangle(4, 5);
            r.area();
            Rectangle s = new Rectangle(5, 8);
            s.area();
            Console.ReadKey();
        }
    }
}
