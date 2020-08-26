using System;

namespace TestProgram7
{
    //7.
     class Program
     {
         static void Main(string[] args)
         {
             int[] num = new int[5];
             int i = 1;
             Console.WriteLine("enter number: ");
             for(i=0;i<5;i++)
             {
                 num[i] = int.Parse(Console.ReadLine());
             }
             int Negative = 0,positive=0;
             for (i = 0; i < 5; i++)
             {
                 if (num[i] < 0)
                 {
                      Negative++;
                     Console.WriteLine(num[i] + " is Negattive Number");
                 }
                 if (num[i] > 0)
                 {
                     positive++;
                     Console.WriteLine(num[i] + " is Positive Number");
                 }
                 Console.WriteLine("\n");  
             }
             Console.WriteLine("total Positive numbers are: " + positive);

             Console.WriteLine("total Negative numbers are: " + Negative);


             Console.ReadKey();
         }
     }
}
