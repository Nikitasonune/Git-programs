using System;

namespace SwappingBitOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Bitwise shift 2 bits left
             int num;
             Console.WriteLine("Enter number: ");
             num = int.Parse(Console.ReadLine());
             num <<= 2;
             Console.WriteLine("The shifted data by two bits to the left is:   " + num);


        }
    }
}
