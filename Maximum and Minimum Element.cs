using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var numberStack = new Stack<int>();


            for (int i = 0; i < input; i++)
            {
                var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (nums[0] == 1)
                {
                    numberStack.Push(nums[1]);
                }
                else if (nums[0] == 2)
                {
                    if (numberStack.Any())
                    {
                        numberStack.Pop();
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (nums[0] == 3)
                {
                    if (numberStack.Any())
                    {
                        Console.WriteLine(numberStack.Max());
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (nums[0] == 4)
                {
                    if (numberStack.Any())
                    {
                        Console.WriteLine(numberStack.Min());
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }

            if (numberStack.Any())
            {
                Console.WriteLine(string.Join(", ", numberStack));
            }
        }
    }
}
