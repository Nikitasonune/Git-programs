using System;

namespace TestProgram2
{
    //2.read 5 number and sum all odd values between them
     class Program
     {
         static void Main(string[] args)
         {
             int sum = 0;
             int[] num=new int[5];
             Console.WriteLine("enter number 1: ");
             num[0] = int.Parse(Console.ReadLine());
             Console.WriteLine("enter number 2: ");
             num[1] = int.Parse(Console.ReadLine());
             Console.WriteLine("enter number 3: ");
             num[2]=int.Parse(Console.ReadLine());
             Console.WriteLine("enter number 4: ");
             num[3] = int.Parse(Console.ReadLine());
             Console.WriteLine("enter number 5: ");
             num[4] = int.Parse(Console.ReadLine());
             for(int i = 0; i < 5; i++)
             {
                 if(num[i]%2!=0)
                 {
                     sum=sum + num[i];
                 }
             }
             Console.WriteLine("Sum of all odd numbers are: " + sum);
             Console.ReadKey();
         }
     }
}
