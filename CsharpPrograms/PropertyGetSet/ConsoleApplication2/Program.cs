using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_set_get
{
    class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            Console.WriteLine("enter employee id: ");
            e.Employee_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name: ");
            e.Employee_Name = Console.ReadLine();
            Console.WriteLine("employee id: " + e.Employee_Id);
            Console.WriteLine("employee name: " + e.Employee_Name);
            Console.ReadKey();

        }
    }
    class employee
    {
        private int emp_id;
        private string emp_name;

        public int Employee_Id
        {
            get
            {
                return emp_id;
            }
            set
            {
                emp_id = value;
            }
        }
        public string Employee_Name
        {
            get
            {
                return emp_name;
            }
            set
            {
                emp_name = value;
            }
        }
    }
}
