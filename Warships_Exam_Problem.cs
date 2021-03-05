using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warships_Exam_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] attacks = Console.ReadLine().Split(',').ToArray();

            int firstPlayerShips = 0;
            int secondPlayerShips = 0;
            int totalShips = 0;

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                char[] currentRow = line.Split().Select(char.Parse).ToArray();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == '<')
                    {
                        firstPlayerShips++;
                    }
                    else if (matrix[row, col] == '>')
                    {
                        secondPlayerShips++;
                    }
                }
            }

            totalShips = firstPlayerShips + secondPlayerShips;

            for (int i = 0; i < attacks.Length; i++)
            {
                string[] coordinates = attacks[i].Split().ToArray();
                int row = int.Parse(coordinates[0]);
                int col = int.Parse(coordinates[1]);

                if (!IsValidRow(row, n) || !IsValidCol(col, n))
                {
                    continue;
                }

                if (i % 2 == 0)
                {
                    if (matrix[row, col] == '>')
                    {
                        matrix[row, col] = 'X';
                        secondPlayerShips--;
                    }
                    else if (matrix[row, col] == '#')
                    {
                        if (matrix[row, col + 1] == '>')
                        {
                            matrix[row, col + 1] = 'X';
                            secondPlayerShips--;
                        }
                        else if (matrix[row, col + 1] == '<')
                        {
                            matrix[row, col + 1] = 'X';
                            firstPlayerShips--;
                        }

                        if (matrix[row + 1, col] == '>')
                        {
                            matrix[row + 1, col] = 'X';
                            secondPlayerShips--;
                        }
                        else if (matrix[row + 1, col] == '<')
                        {
                            matrix[row + 1, col] = 'X';
                            firstPlayerShips--;
                        }

                        if (matrix[row + 1, col + 1] == '>')
                        {
                            matrix[row + 1, col + 1] = 'X';
                            secondPlayerShips--;
                        }
                        else if (matrix[row + 1, col + 1] == '<')
                        {
                            matrix[row + 1, col + 1] = 'X';
                            firstPlayerShips--;
                        }
                    }
                }
                else
                {
                    if (matrix[row, col] == '<')
                    {
                        matrix[row, col] = 'X';
                        firstPlayerShips--;
                    }
                    else if (matrix[row, col] == '#')
                    {
                        if (matrix[row, col + 1] == '>')
                        {
                            matrix[row, col + 1] = 'X';
                            secondPlayerShips--;
                        }
                        else if (matrix[row, col + 1] == '<')
                        {
                            matrix[row, col + 1] = 'X';
                            firstPlayerShips--;
                        }

                        if (matrix[row + 1, col] == '>')
                        {
                            matrix[row + 1, col] = 'X';
                            secondPlayerShips--;
                        }
                        else if (matrix[row + 1, col] == '<')
                        {
                            matrix[row + 1, col] = 'X';
                            firstPlayerShips--;
                        }

                        if (matrix[row + 1, col + 1] == '>')
                        {
                            matrix[row + 1, col + 1] = 'X';
                            secondPlayerShips--;
                        }
                        else if (matrix[row + 1, col + 1] == '<')
                        {
                            matrix[row + 1, col + 1] = 'X';
                            firstPlayerShips--;
                        }
                    }
                }

                int totalCountShipsDestroyed = totalShips - (firstPlayerShips + secondPlayerShips);

                if (firstPlayerShips == 0)
                {
                    Console.WriteLine("Player Two has won the game! {0} ships have been sunk in the battle.", totalCountShipsDestroyed);
                    break;
                }
                else if (secondPlayerShips == 0)
                {
                    Console.WriteLine("Player One has won the game! {0} ships have been sunk in the battle.", totalCountShipsDestroyed);
                    break;
                }

            }

            if (firstPlayerShips > 0 && secondPlayerShips > 0)
            {
                Console.WriteLine("It's a draw! Player One has {0} ships left. Player Two has {1} ships left.", firstPlayerShips, secondPlayerShips);
            }

        }
        public static bool IsValidRow(int n, int rows)
        {
            if (n < 0 || n > rows - 1)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidCol(int n, int cols)
        {
            if (n < 0 || n > cols - 1)
            {
                return false;
            }
            return true;
        }
    }
    
}
