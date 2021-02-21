using System;
using System.Linq;
using System.Collections.Generic;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] effects = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] casings = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> effectQueue = new Queue<int>(effects);
            Stack<int> casingStack = new Stack<int>(casings);

            Dictionary<string, int> bombs = new Dictionary<string, int>();
            string d = "Datura Bombs";
            bombs.Add(d, 0);
            string c = "Cherry Bombs";
            bombs.Add(c, 0);
            string s = "Smoke Decoy Bombs";
            bombs.Add(s, 0);

            while (true)
            {
                if (effectQueue.Count == 0 || casingStack.Count == 0)
                {
                    break;
                }
                int currentEffect = effectQueue.Peek();
                int currentCasing = casingStack.Peek();
                int sum = currentEffect + currentCasing;

                if (sum == 40)
                {
                    bombs["Datura Bombs"]++;
                    casingStack.Pop();
                    effectQueue.Dequeue();
                }
                else if (sum == 60)
                {
                    bombs["Cherry Bombs"]++;
                    casingStack.Pop();
                    effectQueue.Dequeue();
                }
                else if (sum == 120)
                {
                    bombs["Smoke Decoy Bombs"]++;
                    casingStack.Pop();
                    effectQueue.Dequeue();
                }
                else
                {
                    while (true)
                    {
                        currentCasing -= 5;
                        if (sum == 40)
                        {
                            bombs["Datura Bombs"]++;
                            casingStack.Pop();
                            effectQueue.Dequeue();
                            break;
                        }
                        else if (sum == 60)
                        {
                            bombs["Cherry Bombs"]++;
                            casingStack.Pop();
                            effectQueue.Dequeue();
                            break;
                        }
                        else if (sum == 120)
                        {
                            bombs["Smoke Decoy Bombs"]++;
                            casingStack.Pop();
                            effectQueue.Dequeue();
                            break;
                        }
                    }
                }
            }

            if (bombs.Count(x => x.Value >= 3) == 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");

                if (effectQueue.Count == 0)
                {
                    Console.WriteLine("Bomb Effects: empty");
                }
                else if (effectQueue.Count > 0)
                {
                    Console.Write("Bomb Effects: " + string.Join(", ", effectQueue));
                }
                Console.WriteLine();

                if (casingStack.Count == 0)
                {
                    Console.WriteLine("Bomb Casings: empty");
                }
                else if (casingStack.Count > 0)
                {
                    Console.Write("Bomb Casings: " + string.Join(", ", casingStack));
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");

                if (effectQueue.Count == 0)
                {
                    Console.WriteLine("Bomb Effects: empty");
                }
                else if (effectQueue.Count > 0)
                {
                    Console.WriteLine("Bomb Effects: " + string.Join(", ", effectQueue));
                }

                if (casingStack.Count == 0)
                {
                    Console.WriteLine("Bomb Casings: empty");
                }
                else if (casingStack.Count > 0)
                {
                    Console.Write("Bomb Casings: " + string.Join(", ", casingStack));
                }
                Console.WriteLine();
            }

            foreach (var bomb in bombs.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", bomb.Key, bomb.Value);
            }

        }
    }
}
