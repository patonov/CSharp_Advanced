using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Queue_Operations
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

            var numberQueue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                numberQueue.Enqueue(numbers[i]);
            }

            if (s <= numberQueue.Count)
            {
                for (int i = 0; i < s; i++)
                {
                    numberQueue.Dequeue();
                }
            }

            bool isFound = numberQueue.Contains(x);

            if (isFound && numberQueue.Count > 0)
            {
                Console.WriteLine("true");
            }
            else if (numberQueue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                while (numberQueue.Count > 0)
                {
                    var temp = numberQueue.Peek();
                    if (temp < minNum)
                    {
                        minNum = temp;
                    }
                    numberQueue.Dequeue();
                }

                Console.WriteLine(minNum);
            }
        }
    }
}
