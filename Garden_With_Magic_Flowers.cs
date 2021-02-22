using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_With_Magic_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dims = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dims[0];
            int m = dims[1];

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            string command = Console.ReadLine();

            while (command != "Bloom Bloom Plow")
            {
                var comArr = command.Split().Select(int.Parse).ToArray();
                int a = comArr[0];
                int b = comArr[1];

                if (!IsValid(a, b, n, m))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (row == a || col == b)
                            {
                                matrix[row, col] += 1;
                            }
                        }
                    }

                }
                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }



        }
        public static bool IsValid(int row, int col, int n, int m)
        {
            if (row < 0 || row >= n)
            {
                return false;
            }
            if (col < 0 || col >= m)
            {
                return false;
            }
            return true;
        }
    }

}
