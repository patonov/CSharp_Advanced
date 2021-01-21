using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> nums = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!nums.ContainsKey(number))
                {
                    nums.Add(number, 0);
                }
                nums[number]++;
            }

            Dictionary<int, int> evenNums = nums.Where(k => k.Value % 2 == 0).ToDictionary(k => k.Key, v => v.Value);
            KeyValuePair<int, int> kvp = evenNums.First();
            Console.WriteLine(kvp.Key);
        }
    }
}
