using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            int playerRow = -1;
            int playerCol = -1;

            char[,] field = new char[n, m];

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < m; col++)
                {
                    field[row, col] = rowData[col];

                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;

            foreach (char dir in directions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                if (dir == 'U')
                {
                    newPlayerRow--;
                }
                else if (dir == 'D')
                {
                    newPlayerRow++;
                }
                else if (dir == 'L')
                {
                    newPlayerCol--;
                }
                else if (dir == 'R')
                {
                    newPlayerCol++;
                }

                if (!IsValidCell(newPlayerRow, newPlayerCol, n, m))
                {
                    isWon = true;
                    field[playerRow, playerCol] = '.';

                    List<int[]> bunniesDetails = GetBunnyCoordinates(field);
                    SpreadBunnies(bunniesDetails, field);
                }
                else if (field[newPlayerRow, newPlayerCol] == '.')
                {
                    field[playerRow, playerCol] = '.';
                    field[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;

                    List<int[]> bunniesDetails = GetBunnyCoordinates(field);
                    SpreadBunnies(bunniesDetails, field);

                    if (field[playerRow, playerCol] == 'B')
                    {
                        isDead = true;

                    }
                }
                else if (field[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    field[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;

                    List<int[]> bunniesDetails = GetBunnyCoordinates(field);
                    SpreadBunnies(bunniesDetails, field);
                }

                if (isDead || isWon)
                {
                    break;
                }
            }

            PrintField(field);
            string result = string.Empty;

            if (isWon)
            {
                result = "won";
            }
            else
            {
                result = "dead";
            }

            result += $": {playerRow} {playerCol}";
            Console.WriteLine(result);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void SpreadBunnies(List<int[]> bunniesDetails, char[,] field)
        {
            foreach (int[] bunnyCoords in bunniesDetails)
            {
                int row = bunnyCoords[0];
                int col = bunnyCoords[1];

                SpreadBunny(row - 1, col, field);
                SpreadBunny(row + 1, col, field);
                SpreadBunny(row, col - 1, field);
                SpreadBunny(row, col + 1, field);
             }
        }

        private static void SpreadBunny(int row, int col, char[,] field)
        {
            int rowLength = field.GetLength(0);
            int colLength = field.GetLength(1);
            if (IsValidCell(row, col, rowLength, colLength))
            {
                field[row, col] = 'B';
            }
        }

        private static List<int[]> GetBunnyCoordinates(char[,] field)
        {
            List<int[]> bunniesDetails = new List<int[]>();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        bunniesDetails.Add(new int[] { row, col});
                    }
                }
            }
            return bunniesDetails;
        }

        private static bool IsValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
