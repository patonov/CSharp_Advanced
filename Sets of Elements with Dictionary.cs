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
            Dictionary<int, int> numDict = new Dictionary<int, int>();


            for (int i = 0; i < n + m; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!numDict.ContainsKey(input))
                {
                    numDict.Add(input, 1);
                }
                else
                {
                    numDict[input]++;
                }
            }

            foreach (var item in numDict.OrderBy(x => x.Value != 1))
            {
                if (item.Value > 1)
                {
                    Console.Write(item.Key + " ");
                }
            }

        }
    }
}
