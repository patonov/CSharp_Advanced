using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            int minNum = int.MaxValue;

            var numberStack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                numberStack.Push(numbers[i]);
            }

            if (s <= numberStack.Count)
            {
                for (int i = 0; i < s; i++)
                {
                    numberStack.Pop();
                }
            }

            bool isFound = numberStack.Contains(x);

            if (isFound && numberStack.Count > 0)
            {
                Console.WriteLine("true");
            }
            else if (numberStack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {

                while (numberStack.Count > 0)
                {
                    var temp = numberStack.Peek();
                    if (temp < minNum)
                    {
                        minNum = temp;
                    }
                    numberStack.Pop();
                }

            Console.WriteLine(minNum);
            }
        }
    }
}
