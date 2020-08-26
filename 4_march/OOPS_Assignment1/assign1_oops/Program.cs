using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1_oops
{
     
          //1.
             class Student
             {
                 public string Name;
                 public int RollNumber;
                 public void getdata(int rollNumber,string name)
                 {
                     RollNumber = rollNumber;
                     Name = name;
                 }
                 public void setdata()
                 {
                     Console.WriteLine("Student Roll number is: " + RollNumber);
                     Console.WriteLine("Student Name is: " + Name);
                 }

             }
             class Program
             {
                 static void Main(string[] args)
                 {
                     Student s = new Student();

                     s.getdata(2, "John");
                     s.setdata();
                     Console.ReadKey();
                 }
             }
    
    }

    

