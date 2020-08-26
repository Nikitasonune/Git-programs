using System;

namespace OOPS_Assignment2
{
    //2.
    class Student
    {
        public int PhoneNumber { set; get; }
        public int RollNumber { set; get; }
        public string Address { set; get; }
        public string Name;
        public void getdata(string name,int rollNumber, int phoneNumber,string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            RollNumber = rollNumber;
            Address = address;
        }
        public void setdata()
        {
            Console.WriteLine("Student Name is: " + Name);
            Console.WriteLine("Student Phone number is: " + PhoneNumber);
            Console.WriteLine("Student Roll number is: " + RollNumber);
            Console.WriteLine("Student Address is: " + Address);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Enter Roll number: ");
            int rno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone number: ");
            int pH = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student Address: ");
            string add = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Student 1 Detaile are: ");

            s.getdata("John",rno,pH,add);
            s.setdata();


            Student obj = new Student();
            Console.WriteLine("\nEnter Roll number: ");
            int Rno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone number: ");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("\nStudent 2 Detaile are: ");
            obj.getdata("Sam", Rno, phone, address);
            obj.setdata();
            Console.ReadKey();
        }
    }
}
