using System;

namespace SumOf2numWithReturnType
{
    class Program
    {
        //3.Sum of two number(With argument and with return type)
        static void Main(string[] args)
        {
            int num1, num2, res;
            Console.WriteLine("enter number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2: ");
            num2 = int.Parse(Console.ReadLine());
            Program obj = new Program();
            res = obj.addition(num1, num2);
            Console.WriteLine("Sum of two numbers are: " + res);
            Console.ReadKey();
        }
        public int addition(int a, int b)
        {
            int sum;
            sum = a + b;
            return sum;


        }
    }

}

