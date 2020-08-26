using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_7
{
        class Area
        {
            public int length;
            public int breadth;
            public int area;
            
           

            public Area(int len, int brd)
            {
                length = len;
                breadth = brd;
            }
            public int returnArea()
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

                Area obj = new Area(len,brd);
               
                int res = obj.returnArea();

                Console.WriteLine("Area of Rectangle is: " + res);
                Console.ReadKey();

            }
        }
    }
    

