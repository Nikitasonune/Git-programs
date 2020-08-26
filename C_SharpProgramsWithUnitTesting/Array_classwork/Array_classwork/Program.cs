using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] marks = new int[5];
            int i;
            for(i=0;i<=4;i++)
            {
                Console.WriteLine("enter subject marks ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;
            foreach(int m in marks)
            {
                total = total + m;
                Console.WriteLine("marks= " + m);
            }
            Console.WriteLine("total marks are: " + total);
            float percentage = (float)total / 500.0f * 100.0f;
            Console.WriteLine("percentage: " + percentage);
            if(percentage>=85)
            {
                Console.WriteLine("passed with first grade");

            }
            else if(percentage>=60)
            {
                Console.WriteLine("passed with second grade");
            }
            else
            {
                Console.WriteLine("passed with third grade");
            }
            Console.ReadKey();

        }
    }
}
