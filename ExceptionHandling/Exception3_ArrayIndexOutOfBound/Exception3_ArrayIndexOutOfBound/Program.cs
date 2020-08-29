using System;

namespace Exception3_ArrayIndexOutOfBound
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Array Index out of range (bound)
             try
             {
                 int[] arr = new int[3];
                 int i;
                 Console.WriteLine("enter array element: ");

                 for (i=0;i<=4;i++)
                 {
                     arr[i] = Convert.ToInt32(Console.ReadLine());

                 }
             }
             catch (DivideByZeroException e)
             {
                 Console.WriteLine(e.Message);
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             Console.WriteLine("code reached till the end");
             Console.ReadKey();
        }
    }
}
