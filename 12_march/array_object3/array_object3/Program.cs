using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_object3
{
    class Student
    {

        public int height;
        public int num;

        public void showdetail(float sum)
        {
            float average = sum / 3;
            Console.WriteLine("The average of marks are: " + average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;
            Student[] obj = new Student[3];
            Student s = new Student();
            for (int i = 0; i < 3; i++)
            {
                obj[i] = new Student();

                Console.WriteLine("Enter student number: ");
                obj[i].num = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter height of student: ");
                obj[i].height= int.Parse(Console.ReadLine());

                sum = sum + obj[i].height;
            }
            Console.WriteLine("The sum of total height of student is: " + sum);
            s.showdetail(sum);

            Console.ReadKey();




        }
    }
}
