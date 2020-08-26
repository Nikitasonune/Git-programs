using System;

namespace PrivateConstuctor
{
    //7.Private constructor
     public class counter
     {
         private counter()
         {


         }
         public static int currentCount;
         public static int IncrementCount()
         {
             return ++currentCount;
         }
     }
     class TestCounter
     {
         static void Main()
         {
             counter.currentCount = 100;
             counter.IncrementCount();
             Console.WriteLine("New count: {0}", counter.currentCount);
             Console.WriteLine("Press any key to exit");

             Console.ReadKey();
         }
     }
}
