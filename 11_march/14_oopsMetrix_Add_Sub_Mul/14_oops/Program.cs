using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_oops
{
    class Matrix
    {
        int row { get; set; }
        int col { get; set; }
        int a { get; set; }
        int b { get; set; }
        int[,] matrix = new int[2, 2];
        int[,] mat = new int[2, 2];
        int i, j;


        
        public void getdata1()
        {
            Console.WriteLine("Enter matrix elements: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Printed matrix elements are: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void getdata2()
        {
            Console.WriteLine("Enter matrix elements: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Printed matrix elements are: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Addittion()
        {
            int[,] result = new int[2, 2];
            Console.WriteLine("Addittion of two matrix are: ");
            for(i=0;i<2;i++)
            {
                for(j=0;j<2;j++)
                {
                    result[i, j] = matrix[i, j] + mat[i, j];
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Multiplication()
        {
            int[,] result = new int[2, 2];
            Console.WriteLine("multiplication of two matrix are: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    result[i, j] = matrix[i, j] * mat[i, j];
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Matrix obj = new Matrix();
                obj.getdata1();
                obj.getdata2();
                obj.Addittion();
                obj.Multiplication();
               
                

                
                Console.ReadKey();
            }
        }
    }
}

