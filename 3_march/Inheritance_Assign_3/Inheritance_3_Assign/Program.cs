using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_3_Assign
{
    //3.
     class Member
      {
          public string Name { get; set; }
          public int Age { get; set; }
          public int PhoneNumber { get; set; }
          public string Address { get; set; }
          public double Salary { get; set; }
          //method
          public void printSalary(string name, int age, int phonenumber, string address, double salary)
          {
              Name = name;
              Age = age;
              PhoneNumber = phonenumber;
              Address = address;
              Salary = salary;
              Console.WriteLine("Name is: " + Name);
              Console.WriteLine("age is: " + Age);
              Console.WriteLine("phone number is: " + PhoneNumber);
              Console.WriteLine("Address is: " + Address);
              Console.WriteLine("Salary is: " + Salary);
          }

      }
      class Employee : Member
      {
          public string Specialization { get; set; }
          public void special()
          {
              Console.WriteLine("specilization is singing");
          }
      }
      class Manager : Member
      {
          public string department { get; set; }
          public void depo()
          {
              Console.WriteLine("Department is Manager");
          }
      }
      class Program
      {

          static void Main(string[] args)
          {
              Member obj = new Member();
              Console.WriteLine("Enter Name: ");
              string name = Console.ReadLine();
              Console.WriteLine("Enter Age: ");
              int age = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Phone number: ");
              int phonenumber = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Address: ");
              string address = Console.ReadLine();
              Console.WriteLine("Enter Salary:");
              double salary = double.Parse(Console.ReadLine());

              Console.WriteLine();
              Employee e = new Employee();
              e.printSalary(name, age, phonenumber, address, salary);
              e.special();
              Console.WriteLine();
              Manager m = new Manager();
              m.printSalary(name, age, phonenumber, address, salary);
              m.depo();
              Console.ReadKey();

          }
      }
}
