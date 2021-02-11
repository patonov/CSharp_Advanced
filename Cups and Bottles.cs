using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesValue = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var cupsQueue = new Queue<int>(cupsCapacity);
            var bottleStack = new Stack<int>(bottlesValue);

            int waterWaste = 0;

            while (true)
            {
                int currentBottle = bottleStack.Pop();

                if (currentBottle < cupsQueue.Peek())
                {
                    int currentCup = cupsQueue.Dequeue();
                    currentCup -= currentBottle;
                    while (true)
                    {
                        int lastBottle = bottleStack.Pop();
                        if (lastBottle < currentCup)
                        {
                            currentCup -= lastBottle;
                        }
                        else
                        {
                            waterWaste += lastBottle - currentCup;
                            break;
                        }

                        if (bottleStack.Count == 0)
                        {
                            Console.WriteLine("Cups: {0} {1}", currentCup, string.Join(" ", cupsQueue));
                            Console.WriteLine("Wasted litters of water: {0}", waterWaste);
                            return;
                        }
                    }
                }
                else if (currentBottle >= cupsQueue.Peek())
                {
                    waterWaste += currentBottle - cupsQueue.Peek();
                    cupsQueue.Dequeue();
                }

                if (cupsQueue.Count == 0)
                {
                    Console.WriteLine("Bottles: {0}", string.Join(" ", bottleStack));
                    Console.WriteLine("Wasted litters of water: {0}", waterWaste);
                    return;
                }
                else if (bottleStack.Count == 0)
                {
                    Console.WriteLine("Cups: {0}", string.Join(" ", cupsQueue));
                    Console.WriteLine("Wasted litters of water: {0}", waterWaste);
                    return;
                }
            }
        }
    }
}
