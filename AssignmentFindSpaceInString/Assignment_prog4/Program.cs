using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_prog4
{
    public class Program
    {
        //4.find spaces in string
        static void Main(string[] args)
        {
            string str;
            int i;
            Console.WriteLine("enter any string: ");
            str = Console.ReadLine();
            Program obj = new Program();

            i = obj.function(str);
            Console.WriteLine(i);
            Console.ReadKey();
        }
        public int function(string a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

    }
}
