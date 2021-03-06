﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondBox = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> firstBoxQueue = new Queue<int>(firstBox);
            Stack<int> secondBoxStack = new Stack<int>(secondBox);
            List<int> claimedThings = new List<int>();

            while (firstBoxQueue.Count > 0 && secondBoxStack.Count > 0)
            {
                int firstBoxThing = firstBoxQueue.Peek();
                int secondBoxThing = secondBoxStack.Peek();
                int sum = firstBoxThing + secondBoxThing;
                if (sum % 2 == 0)
                {
                    claimedThings.Add(sum);
                    firstBoxQueue.Dequeue();
                    secondBoxStack.Pop();
                }
                else
                {
                    int term = secondBoxStack.Pop();
                    firstBoxQueue.Enqueue(term);
                }
            }

            if (firstBoxQueue.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBoxStack.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedThings.Sum() >= 100)
            {
                Console.WriteLine("Your loot was epic! Value: {0}", claimedThings.Sum());
            }
            else
            {
                Console.WriteLine("Your loot was poor... Value: {0}", claimedThings.Sum());
            }

        }
    }
}
