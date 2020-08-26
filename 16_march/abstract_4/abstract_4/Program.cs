using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_3
{
    abstract class Marks
    {
        public float Percentage, total;
        public abstract float getPercentage();
    }
    class A : Marks
    {
        public A(float S1,float S2,float S3)
        {
            total = S1 + S2 + S3;
            Console.WriteLine("Total marks is: " + total);
        }
        public override float getPercentage()
        {
            Percentage = (total / 300) * 100;
            return Percentage;
        }
    }
    class B : Marks
    {
        public B(float A1, float A2, float A3,float A4)
        {
            total = A1 + A2 + A3 + A4;
            Console.WriteLine("Total marks is: " + total);
        }
        public override float getPercentage()
        {
            Percentage = (total / 400) * 100;
            return Percentage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks for student A");
            Console.WriteLine("\nEnter Marks of Maths: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of Science: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of English: ");
            float num3 = float.Parse(Console.ReadLine());

            A obj1 = new A(num1, num2, num3);
            float result=obj1.getPercentage();
            Console.WriteLine("\nPercentage obtained is: " + result);

            Console.WriteLine("\n\nEnter Marks for student B");
            Console.WriteLine("Enter Marks of Maths: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of Science: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of English: ");
            float n3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of Hindi: ");
            float n4 = float.Parse(Console.ReadLine());

            B obj2 = new B(n1,n2,n3,n4);
            float res=obj2.getPercentage();
            Console.WriteLine("\nPercentage obtained is: " + res);

            Console.ReadKey();



        }
    }
}

