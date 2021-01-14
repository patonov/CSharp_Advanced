using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());

            var queueOfNums = new Queue<string>();

            for (int i = 0; i < name.Length; i++)
            {
                queueOfNums.Enqueue(name[i]);
            }

            while (queueOfNums.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {
                    queueOfNums.Enqueue(queueOfNums.Dequeue());
                }
                Console.WriteLine("Removed {0}", queueOfNums.Dequeue());
            }

            Console.WriteLine("Last is {0}", queueOfNums.Dequeue());

        }
    }
}
