using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            Func<int, int> arithmFunc = num => num;
            Action<List<int>> print = num => Console.WriteLine(string.Join(" ", nums));

            while (command != "end")
            {
                if (command == "add")
                {
                    arithmFunc = num => num + 1;
                    nums = nums.Select(n => arithmFunc(n)).ToList();
                }
                else if (command == "multiply")
                {
                    arithmFunc = num => num * 2;
                    nums = nums.Select(n => arithmFunc(n)).ToList();
                }
                else if (command == "subtract")
                {
                    arithmFunc = num => num - 1;
                    nums = nums.Select(n => arithmFunc(n)).ToList();
                }
                else if (command == "print")
                {
                    print(nums);
                }

                command = Console.ReadLine();
            }

        }
    }
}
