using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_ques10
{

    //10                                                                                                                                                                                                                           
    class Employee
    {
        public string Name;
        public int Year;
        public double Salary;
        public string Address;
        public string getdata(string name, int year,string address)
        {
            return name + "         " + year + "            " + address;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee[] obj = new Employee[3];
            for(int i=0;i<3;i++)
            {
                obj[i]  = new Employee();
                Console.WriteLine("Enter Name: ");
                obj[i].Name = Console.ReadLine();
                Console.WriteLine("Enter year of joining: ");
                obj[i].Year =int.Parse( Console.ReadLine());
                Console.WriteLine("Enter Address: ");
                obj[i].Address = Console.ReadLine();
                         
            }
            Console.WriteLine("Name     Year of Joining     Address");
            for(int i=0;i<3;i++)
            {
                string res = obj[i].getdata(obj[i].Name, obj[i].Year, obj[i].Address);
                Console.WriteLine(res);
            }
            Console.ReadKey();
            
            
            
            
        }
    }
}
