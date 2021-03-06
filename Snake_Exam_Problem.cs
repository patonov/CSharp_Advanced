using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Exam_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int firstRow = 0;
            int firstCol = 0;

            for (int row = 0; row < n; row++)
            {
                char[] curRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = curRow[col];
                    if (matrix[row, col] == 'S')
                    {
                        firstRow = row;
                        firstCol = col;
                    }
                }
            }
            int currentRow = firstRow;
            int currentCol = firstCol;
            matrix[currentRow, currentCol] = '.';

            string command = Console.ReadLine();
            int foodEaten = 0;

            while (true)
            {
                currentRow = MoveRow(currentRow, command);
                currentCol = MoveCol(currentCol, command);

                if (!IsValid(currentRow, currentCol, n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (matrix[currentRow, currentCol] == '*')
                {
                    matrix[currentRow, currentCol] = '.';
                    foodEaten++;
                    if (foodEaten >= 10)
                    {
                        matrix[currentRow, currentCol] = 'S';
                        Console.WriteLine("You won! You fed the snake.");
                        break;
                    }
                }
                else if (matrix[currentRow, currentCol] == 'B')
                {
                    matrix[currentRow, currentCol] = '.';
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'B')
                            {
                                currentRow = row;
                                currentCol = col;
                                matrix[currentRow, currentCol] = '.';
                            }
                        }
                    }
                }
                matrix[currentRow, currentCol] = '.';
                command = Console.ReadLine();
            }

            Console.WriteLine("Food eaten: {0}", foodEaten);

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }


        }
        public static bool IsValid(int row, int col, int n)
        {
            if (row < 0 || row >= n)
            {
                return false;
            }
            if (col < 0 || col >= n)
            {
                return false;
            }
            return true;
        }

        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }

            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "right")
            {
                return col + 1;
            }

            if (movement == "left")
            {
                return col - 1;
            }

            return col;

        }
    
    }
}
