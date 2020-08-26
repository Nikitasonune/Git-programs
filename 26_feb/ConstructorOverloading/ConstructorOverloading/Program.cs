using System;

namespace ConstructorOverloading
{
    //5.constructor overloading
      public class Employee
      {
          public int salary;
          public Employee(int annualSalary)
          {
              salary = annualSalary;
          }
          public Employee(int weeklySalary,int numberOfWeek)
          {
              salary = weeklySalary * numberOfWeek;
          }

      }
      class Program
      {
          static void Main(string[]args)
          {
              Employee e = new Employee(5000);
              Console.WriteLine("annual salary " + e.salary);
              Employee obj = new Employee(7000,4);
              Console.WriteLine("annual salary " + obj.salary);
              Console.ReadKey();
          }
      }
}
