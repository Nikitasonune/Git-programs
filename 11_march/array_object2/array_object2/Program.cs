using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_object2
{
    class Student
    {
       
        public int Roll,science,maths,english;
        
        public void showdetail(int roll,float sum)
        {
            Console.WriteLine("Roll number of student: " + roll);
            float average = sum / 3;
            Console.WriteLine("The average of marks are: " + average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float sum=0;
            Student[] obj = new Student[3];
            for (int i = 0; i < 8; i++)
            {
                obj[i] = new Student();
                Console.WriteLine("Enter Roll Number ");
                obj[i].Roll = int.Parse( Console.ReadLine());

                Console.WriteLine("Enter Marks of science ");
                obj[i].science = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Marks of Mathematics ");
                obj[i].maths = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Marks of English ");
                obj[i].english = int.Parse(Console.ReadLine());

                sum = obj[i].science + obj[i].maths + obj[i].english;

                Console.WriteLine("The sum of total marks are: " + sum);
                obj[i].showdetail(obj[i].Roll, sum);
            }
            
            Console.ReadKey();




        }
    }
    
}
