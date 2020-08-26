using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4
{
    public class Program
    {
        //5.addittion of array element
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int result,i;
            Console.WriteLine("enter 5 array element: ");
            for (i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Program obj = new Program();
            result = obj.function(arr);
            Console.WriteLine("sum of array elements are: " + result);
            Console.ReadKey();
        }
        public int function(int []b)
        {
            int i,sum=0;
            
            for(i=0;i<5;i++)
            {
                sum = sum + b[i];
            }
            return sum;
        }
    }
}
