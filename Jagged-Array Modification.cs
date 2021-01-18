using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputData[col];
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                int comRow = int.Parse(command[1]);
                int comCol = int.Parse(command[2]);
                int comValue = int.Parse(command[3]);

                if (command[0] == "Add")
                {
                    if (comRow > matrix.GetLength(0) - 1 || comCol > matrix.GetLength(1) - 1 || comRow < 0 || comCol < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[comRow, comCol] += comValue;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (comRow > matrix.GetLength(0) - 1 || comCol > matrix.GetLength(1) - 1 || comRow < 0 || comCol < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[comRow, comCol] -= comValue;
                    }
                }
                command = Console.ReadLine().Split();
            }

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
}
