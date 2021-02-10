using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int denominator = int.Parse(Console.ReadLine());

            nums.Reverse();

            nums = nums.Where(x => x % denominator != 0).ToList();

            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));
            print(nums);

        }
    }
}
