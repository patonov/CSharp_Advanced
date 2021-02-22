using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> dividersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> endNumbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (IsDivider(i, dividersList))
                {
                    endNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", endNumbers));
        }

        private static bool IsDivider(int n, List<int> dividersList)
        {
            bool isTrue = true;

            foreach (var divider in dividersList)
            {
                if (n % divider != 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    }
    }
}
