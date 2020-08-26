using System;

namespace TestProgram5
{
    //5.Even number 1-50
     class Program
     {
         static void Main(string[] args)
         {
             int i = 1;
             while (i <= 50)
             {
                if(i%2==0)
                 {
                     Console.WriteLine("Even numbers are: " + i);
                 }
                 i++;
             }
             Console.ReadKey();
         }
     }
}
