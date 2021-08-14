using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario_Exam_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];

            int firstMarioRow = 0;
            int firstMarioCol = 0;



            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col].ToString();
                    if (matrix[row, col] == "M")
                    {
                        firstMarioRow = row;
                        firstMarioCol = col;
                    }
                }
            }
            int currentRow = firstMarioRow;
            int currentCol = firstMarioCol;

            int oldRow = currentRow;
            int oldCol = currentCol;

            matrix[currentRow, currentCol] = "-";

            string command = Console.ReadLine();


            while (true)
            {
                string[] commArr = command.Split(' ');

                string moveDirect = commArr[0];
                int enemyRow = int.Parse(commArr[1]);
                int enemyCol = int.Parse(commArr[2]);

                currentRow = MoveRow(currentRow, moveDirect);
                currentCol = MoveCol(currentCol, moveDirect);
                e--;

                if (!IsValid(currentRow, currentCol, n))
                {
                    currentRow = oldRow;
                    currentCol = oldCol;

                }

                matrix[enemyRow, enemyCol] = "B";

                if (enemyRow == currentRow && enemyCol == currentCol)
                {
                    e -= 2;
                    if (e <= 0)
                    {
                        matrix[currentRow, currentCol] = "X";
                        Console.WriteLine("Mario died at {0};{1}.", currentRow, currentCol);
                        break;
                    }
                }

                if (matrix[currentRow, currentCol] == "P")
                {
                    Console.WriteLine("Mario has successfully saved the princess! Lives left: {0}", e);
                    matrix[currentRow, currentCol] = "-";
                    break;
                }
                command = Console.ReadLine();
            }



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
            if (movement == "W")
            {
                return row - 1;
            }

            if (movement == "S")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "D")
            {
                return col + 1;
            }

            if (movement == "A")
            {
                return col - 1;
            }

            return col;

        }
    
    }
}
