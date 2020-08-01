using System;

namespace _1DArrayStore_subject_marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int i;
            for (i = 0; i <= 4; i++) 
            {
                Console.WriteLine("Enter marks: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            //displaying the total marks
            int total = 0;
            foreach(int m in marks)
            {
                total = total + m;
                Console.WriteLine("Total marks is: " + m);   
            }
            Console.WriteLine("Total marks is: " + total);
            Console.ReadKey();
        }
    }
}
