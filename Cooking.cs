using System;
using System.Linq;
using System.Collections.Generic;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquids = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ingredients = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> liquidQueue = new Queue<int>(liquids);
            Stack<int> ingStack = new Stack<int>(ingredients);

            Dictionary<string, int> food = new Dictionary<string, int>();
            string bread = "Bread";
            food.Add(bread, 0);
            string cake = "Cake";
            food.Add(cake, 0);
            string pastry = "Pastry";
            food.Add(pastry, 0);
            string pie = "Fruit Pie";
            food.Add(pie, 0);


            while (true)
            {
                if (liquidQueue.Count == 0 || ingStack.Count == 0)
                {
                    break;
                }
                int currentLiquid = liquidQueue.Peek();
                int currentIng = ingStack.Peek();

                if (currentLiquid + currentIng == 25)
                {
                    food[bread]++;
                    liquidQueue.Dequeue();
                    ingStack.Pop();
                }
                else if (currentLiquid + currentIng == 50)
                {
                    food[cake]++;
                    liquidQueue.Dequeue();
                    ingStack.Pop();
                }
                else if (currentLiquid + currentIng == 75)
                {
                    food[pastry]++;
                    liquidQueue.Dequeue();
                    ingStack.Pop();
                }
                else if (currentLiquid + currentIng == 100)
                {
                    food[pie]++;
                    liquidQueue.Dequeue();
                    ingStack.Pop();
                }
                else
                {
                    liquidQueue.Dequeue();
                    int lastIng = ingStack.Pop();
                    lastIng += 3;
                    ingStack.Push(lastIng);
                }

            }

            if (food.Count(x => x.Value > 0) == 4)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquidQueue.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.Write("Liquids left: " + string.Join(", ", liquidQueue));
                Console.WriteLine();
            }

            if (ingStack.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.Write("Ingredients left: " + string.Join(", ", ingStack));
                Console.WriteLine();
            }

            foreach (var item in food.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
}
