using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligValue = int.Parse(Console.ReadLine());

            var bulletStack = new Stack<int>(bullets);
            var locksQueue = new Queue<int>(locks);

            int bulletsUsedCounter = 0;
            int barrelSizeUsedCounter = 0;

            while (bulletStack.Any() && locksQueue.Any())
            {
                if (bulletStack.Peek() <= locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                    bulletStack.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bulletStack.Pop();
                }
                barrelSizeUsedCounter++;

                if (barrelSizeUsedCounter == gunBarrelSize && bulletStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    barrelSizeUsedCounter = 0;
                }
                bulletsUsedCounter++;

            }

            if (bulletStack.Count >= 0 && locksQueue.Count == 0)
            {
                var netProfits = intelligValue - (bulletsUsedCounter * bulletPrice);
                Console.WriteLine("{0} bullets left. Earned ${1}", bulletStack.Count, netProfits);
            }
            else
            {
                Console.WriteLine("Couldn't get through. Locks left: {0}", locksQueue.Count);
            }
        }
    }
}
