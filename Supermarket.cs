using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var queueOfNums = new Queue<string>();

            while (name != "End")
            {

                if (name != "Paid")
                {
                    queueOfNums.Enqueue(name);
                }
                else
                {
                    while (queueOfNums.Any())
                    {
                        Console.WriteLine(queueOfNums.Dequeue());
                    }
                }

                name = Console.ReadLine();
            }
            Console.WriteLine("{0} people remaining.", queueOfNums.Count);

        }
    }
}
