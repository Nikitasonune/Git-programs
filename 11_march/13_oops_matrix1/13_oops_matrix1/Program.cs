using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_oops_matrix1
{
    class Matrix
    {
        int Row { get; set; }
        int Column { get; set; }
        
        public Matrix()
        {
            Console.WriteLine("Enter row of matrix: ");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter column of matrix: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];

            Console.WriteLine("Enter matrix elements: ");
            for(int i=0;i< row;i++)
            {
                for(int j=0;j< col;j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Printed matrix elements are: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix obj = new Matrix();
            Console.ReadKey();
        }
    }
}
