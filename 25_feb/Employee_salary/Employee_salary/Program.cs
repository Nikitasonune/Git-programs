using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter employee Id: ");
            int Id = int.Parse(Console.ReadLine());
           // Console.WriteLine("enter total work hour: ");
           // int hour = int.Parse(Console.ReadLine());
            
            int hour = 10;
            int month = 26;
            int total = month * hour;
            int salary = total * hour;
             
            
            Console.WriteLine("total salary received is: " + salary);
            Console.ReadKey();

        }
    }
}
