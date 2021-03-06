using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpirallyFillingMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            string direction = "right";
            int row = 0;
            int col = 0;

            for (int i = 0; i < n * n; i++)
            {
                matrix[row, col] = i + 1;
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "up")
                {
                    row--;
                }

                if ((col == n || IsOccupied(matrix, row, col, n)) && direction == "right")
                {
                    col--;
                    row++;
                    direction = "down";
                }
                if ((row == n || IsOccupied(matrix, row, col, n)) && direction == "down")
                {
                    row--;
                    col--;
                    direction = "left";
                }
                if ((col == -1 || IsOccupied(matrix, row, col, n)) && direction == "left")
                {
                    col++;
                    row--;
                    direction = "up";
                }
                if ((row == -1 || IsOccupied(matrix, row, col, n)) && direction == "up")
                {
                    row++;
                    col++;
                    direction = "right";
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (matrix[r, c] < 10)
                    {
                        Console.Write(" " + matrix[r, c] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[r, c] + " ");
                    }
                }
                Console.WriteLine();
            }

        }

        public static bool IsOccupied(int[,] matrix, int row, int col, int n)
        {
            return row >= 0 && col >= 0 && row < n && col < n && matrix[row, col] != 0;
        }
    
    }
}
