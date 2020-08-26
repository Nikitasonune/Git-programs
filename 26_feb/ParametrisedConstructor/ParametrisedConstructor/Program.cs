using System;

namespace ParametrisedConstructor
{
    //2.Paramaterized constructror
     public class Person
     {
         private string first;
         private string last;
         public Person(string firstName,string lastName)
         {
             first = firstName;
             last = lastName;
         }
         public void shpwdata()
         {
             Console.WriteLine("first= " + first);
             Console.WriteLine("last= " + last);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             Person obj = new Person("Nikita", "Sonune");
             obj.shpwdata(); 
             Console.ReadKey();
         }
     }
}
