using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyFood = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var ordersQueue = new Queue<int>(orders);

            Console.WriteLine(ordersQueue.Max());
            var orderSum = ordersQueue.Sum();

            if (dailyFood >= orderSum)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                int sum = 0;

                while (sum < dailyFood)
                {
                    sum += ordersQueue.Peek();
                    if (sum > dailyFood)
                    {
                        break;
                    }
                    ordersQueue.Dequeue();
                }
                Console.WriteLine("Orders left: " + string.Join(" ", ordersQueue));
            }
        }
    }
}
