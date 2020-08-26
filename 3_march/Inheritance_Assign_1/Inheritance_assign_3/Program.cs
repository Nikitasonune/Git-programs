using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_assign_3
{
    //1.
    class Parent
     {
         public void showdata()
         {
             Console.WriteLine("This is parent class");
         }
     }
     class child : Parent
     {
         public void showdata2()
         {
             Console.WriteLine("This is child class");
         }

     }
     class Program
     {

         static void Main(string[] args)
         {
             Parent p = new Parent();
             p.showdata();
             child c = new child();
             c.showdata2();
             c.showdata();
             Console.ReadKey();

         }
     }
}

