using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            int knightsToRemove = 0;

            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }


            while (true)
            {
                int maxAttackKnights = int.MinValue;
                int rowMax = int.MinValue;
                int colMax = int.MinValue;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int attackedKnights = 0;
                        if (matrix[row, col] == 'K')
                        {
                            attackedKnights = CheckInFrontOfTheKnight(cols, matrix, row, col, attackedKnights);
                            attackedKnights = CheckBehindTheKnight(rows, cols, matrix, row, col, attackedKnights);
                            attackedKnights = CheckOnLeftTheKnight(rows, matrix, row, col, attackedKnights);
                            attackedKnights = CheckOnRightTheKnight(rows, cols, matrix, row, col, attackedKnights);
                        }

                        if (attackedKnights > maxAttackKnights)
                        {
                            maxAttackKnights = attackedKnights;
                            rowMax = row;
                            colMax = col;
                        }
                    }
                }

                if (maxAttackKnights > 0)
                {
                    matrix[rowMax, colMax] = '0';
                    knightsToRemove++;
                }

                else if (maxAttackKnights == 0)
                {
                    break;
                }
            }

            Console.WriteLine(knightsToRemove);
        }


        private static int CheckOnRightTheKnight(int rows, int cols, char[,] matrix, int row, int col, int attackedKnights)
        {
            if (row + 1 < rows && col + 2 < cols)
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (row - 1 >= 0 && col + 2 < cols)
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            return attackedKnights;
        }

        private static int CheckOnLeftTheKnight(int rows, char[,] matrix, int row, int col, int attackedKnights)
        {
            if (row + 1 < rows && col - 2 >= 0)
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (row - 1 >= 0 && col - 2 >= 0)
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            return attackedKnights;
        }

        private static int CheckBehindTheKnight(int rows, int cols, char[,] matrix, int row, int col, int attackedKnights)
        {
            if (row + 2 < rows && col + 1 < cols)
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (row + 2 < rows && col - 1 >= 0)
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            return attackedKnights;
        }

        private static int CheckInFrontOfTheKnight(int cols, char[,] matrix, int row, int col, int attackedKnights)
        {
            if (row - 2 >= 0 && col + 1 < cols)
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (row - 2 >= 0 && col - 1 >= 0)
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            return attackedKnights;
        }

    }
    
}
