using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = range[0];
            int end = range[1];
            string criterion = Console.ReadLine();

            Func<int, int, List<int>> generateRangeOfNums = (s, e) =>
            {
                List<int> nums = new List<int>();

                for (int i = s; i <= e; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = generateRangeOfNums(start, end);

            Predicate<int> predicate = n => true;

            if (criterion == "odd")
            {
                predicate = n => n % 2 != 0;

            }
            else if (criterion == "even")
            {
                predicate = n => n % 2 == 0;
            }

            Console.WriteLine(string.Join(" ", MyWhere(numbers, predicate)));

        }

        public static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNums = new List<int>();

            foreach (var currentNum in numbers)
            {
                if (predicate(currentNum))
                {
                    newNums.Add(currentNum);
                }

            }
            return newNums;
        }
    }   
}
