using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_object1
{
    class Employee
    {
        public string Name;
        public int Year;
        public double Salary;
        public void showdetail(string Name,int Year,double Salary)
        {
            Console.WriteLine("Employee Details are:");
            
                Console.WriteLine(Name);
                Console.WriteLine(Year);
                Console.WriteLine(Salary);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[]obj = new Employee[10];
            for (int i = 0; i < 10; i++)
            {
                obj[i] = new Employee();
                Console.WriteLine("Enter Name: ");
                obj[i].Name = Console.ReadLine();
                Console.WriteLine("Enter year of joining: ");
                obj[i].Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Salary: ");
                obj[i].Salary = Double.Parse(Console.ReadLine());
            }
            for(int i=0;i<10;i++)
            {
                obj[i].showdetail(obj[i].Name, obj[i].Year, obj[i].Salary);
            }
            Console.ReadKey();




        }
    }
    }

