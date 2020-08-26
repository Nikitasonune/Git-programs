using System;

namespace TestProgram8
{
    //8.
     class Program
     {
         static void Main(string[] args)
         {
             int[] num = new int[5];
             int i = 1,positive=0,res=0;
             Console.WriteLine("enter number: ");
             for (i = 0; i < 5; i++)
             {
                 num[i] = int.Parse(Console.ReadLine());
             }
             for (i = 0; i < 5; i++)
             {
                 if (num[i] > 0)
                 {
                     positive++;
                     res = res + num[i];

                     Console.WriteLine(num[i] + " is Positive Number");
                 }
             }
             Console.WriteLine("addittion of positive numbers are: " + res);
             Console.WriteLine("total Positive numbers are: " + positive);
             float average = res / positive;
             Console.WriteLine("average of positive numbers are: " + average);
             Console.ReadKey();
         }
     }
}
