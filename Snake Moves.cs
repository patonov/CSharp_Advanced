using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = n[0];
            int cols = n[1];

            var matrix = new char[rows, cols];

            var snake = Console.ReadLine();

            int counter = 0;

            var snakeQueue = new Queue<char>();

            int matrixCapacity = rows * cols;

            for (int i = 0; i < matrixCapacity; i++)
            {
                snakeQueue.Enqueue(snake[i]);
                counter++;

                if (counter == matrixCapacity)
                {
                    break;
                }

                if (i == snake.Length - 1)
                {
                    i = -1;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeQueue.Dequeue();
                    }
                }
                else if (row % 2 != 0)
                {
                    for (int lastCol = matrix.GetLength(1) - 1; lastCol >= 0; lastCol--)
                    {
                        matrix[row, lastCol] = snakeQueue.Dequeue();
                    }
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
