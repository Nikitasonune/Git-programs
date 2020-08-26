using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            Console.WriteLine("enter your name");
            Name = Console.ReadLine();
            foreach(char i in Name)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
