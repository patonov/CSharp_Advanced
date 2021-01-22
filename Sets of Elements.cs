using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = nums[0];
            var m = nums[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n + m; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (firstSet.Count < n)
                {
                    firstSet.Add(input);
                }
                else
                {
                    secondSet.Add(input);
                }
            }

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    Console.Write("{0} ", number);
                }
            }
        }
    }
}
