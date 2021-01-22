using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] jArr = new long[n][];

            for (int i = 0; i < n; i++)
            {
                jArr[i] = new long[i + 1];

                for (int j = 0; j < i + 1; j++)
                {
                    if (j > 0 && j < jArr[i].Length - 1)
                    {
                        jArr[i][j] = jArr[i - 1][j - 1] + jArr[i - 1][j];
                    }
                    else
                    {
                        jArr[i][j] = 1;
                    }
                }
            }

            foreach (long[] item in jArr)
            {
                Console.WriteLine(string.Join(" ", item));
            }

        }
    }
}
