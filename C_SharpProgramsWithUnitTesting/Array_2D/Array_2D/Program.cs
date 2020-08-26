using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2D
{
  public class Program
    {
        //with argument with return type
        static void Main(string[] args)
        {
            string[,] album = new string[2, 2];
            string[,] result = new string[2, 2];
            int i, j;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("enter album name and year");
                    album[i, j] = Console.ReadLine();
                }
            }
            Program obj = new Program();

            result = obj.method(album);
            Console.ReadKey();
        }
        public string[,] method(string[,] a)
        {
            int i;
            Console.WriteLine("the album and ablum year is");
            for (i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(a[i, j] + " ");
                }
            }
            return a;
        }


    }
}

