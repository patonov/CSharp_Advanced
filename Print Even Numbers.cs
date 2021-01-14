using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queueOfNums = new Queue<int>();
            var evenNums = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                queueOfNums.Enqueue(numbers[i]);
            }

            while (queueOfNums.Count > 0)
            {
                int temp = queueOfNums.Dequeue();
                if (temp % 2 == 0)
                {
                    evenNums.Add(temp);
                }
            }
            Console.WriteLine(string.Join(", ", evenNums));

        }
    }
}
