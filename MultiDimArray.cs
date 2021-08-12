using System;

namespace MultiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];

            matrix[0, 0] = 5;
            matrix[0, 1] = 7;
            matrix[1, 0] = 9;
            matrix[1, 1] = 11;

            Console.WriteLine("Sum :" + Sum(matrix) + Environment.NewLine);
            Console.WriteLine("Matrix:");
            Printer(matrix);
        }

        public static void Printer(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int Sum(int[,] matrix)
        {
            int n = 0;
            foreach (int v in matrix)
            {
                n += v;
            }
            return n;
        }
    }
}
