using System;

namespace CopyConstructorThroughArrayOfObject
{
    //Copy constructor using user Input through array of object

    class School
   {
       public int Roll_no, No;
       public string Name, na;

       //Instance Constructor
        public School()
       {
           Console.WriteLine("enter student roll number: ");
           Roll_no = int.Parse(Console.ReadLine());

           Console.WriteLine("enter student name: ");
           Name = Console.ReadLine();   
       }

       //copy constructor
       public School(School S)
       {
           No = S.Roll_no;
           na = S.Name;
       }
       public void show()
       {
               Console.WriteLine("Roll number is: " + Roll_no);
               Console.WriteLine("Name is: " + Name);
               Console.WriteLine("\n");
       }

       public void show1()
       {
           Console.WriteLine("copy Constructor");
           Console.WriteLine("Roll number is: " + No);
           Console.WriteLine("Name is: " + na);
       }
   }
   class Program
   {
       static void Main(string[] args)
       {
           int i;
           School[] obj = new School[3];
           for (i = 0; i < 3; i++)
           {
               obj[i] = new School();//Instance Constructor
           }

           for (i = 0; i < 3; i++)
           {
               obj[i].show(); //Instance constructor value printing through method calling
           }

           School[] obj1 = new School[3]; //Copy constructor object
            for (i = 0; i < 3; i++)
            {
               obj1[i] = new School(obj[i]); //copy constructor value printing
               obj1[i].show1();
           }
           Console.ReadKey();
       }
   }
}
