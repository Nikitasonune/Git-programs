using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_oops4
{
    class student
    {
        public string name, address;
        public int age;
        public student()
        {
            name = "unknown";
            age = 0;
            address = "not available";
        }
        public void setInfo(string Name,int Age)
        {
            name = Name;
            age = Age;
        }
        public void setInfo(string Name, int Age, string Address)
        {
            name = Name;
            age = Age;
            address = Address;
            Console.WriteLine("Details of students are: ");
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Age is: " + age);
            Console.WriteLine("Addreaa is: " +address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name=null, address=null;
            int age=0;
            student[] s = new student[10];
            for(int i=0;i<2;i++)
            {
                s[i] = new student();
                Console.WriteLine("Enter name: ");
                s[i].name = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                s[i].age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Address: ");
                s[i].address= Console.ReadLine();
            }
            for (int i = 0; i < 2; i++)
            {
                s[i].setInfo(s[i].name, s[i].age, s[i].address);
            }
            Console.ReadKey();
        }
    }
}
