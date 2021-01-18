using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixParameters = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int rows = matrixParameters[0];
            int cols = matrixParameters[1];
            int columnSum = 0;

            var matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    columnSum += matrix[row, col];

                    if (row == matrix.GetLength(0) - 1)
                    {
                        Console.WriteLine(columnSum);
                        columnSum = 0;
                    }
                }
            }
        }
    }
}
