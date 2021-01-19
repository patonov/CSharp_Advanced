using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = n[0];
            int cols = n[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArr = command.Split().ToArray();

                if (commandArr[0] == "swap" && commandArr.Length == 5)
                {
                    int rowOne = int.Parse(commandArr[1]);
                    int colOne = int.Parse(commandArr[2]);
                    int rowTwo = int.Parse(commandArr[3]);
                    int colTwo = int.Parse(commandArr[4]);

                    if (rowOne > matrix.GetLength(0) - 1 || colOne > matrix.GetLength(1) - 1 || rowTwo > matrix.GetLength(0) - 1 || colTwo > matrix.GetLength(1) - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string firstTempToBeReplaced = matrix[rowOne, colOne];
                        string secondTempForMoving = matrix[rowTwo, colTwo];
                        matrix[rowOne, colOne] = secondTempForMoving;
                        matrix[rowTwo, colTwo] = firstTempToBeReplaced;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }

        }
    }
}
