using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int leftDiagonalSum = 0;
            int counter = n - 1;
            int rightDiagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                leftDiagonalSum += matrix[row, row];
                rightDiagonalSum += matrix[row, counter];
                counter--;
            }

            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));

        }
    }
}
