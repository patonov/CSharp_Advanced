using System;

namespace lastStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hats = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] scarfs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> hatStack = new Stack<int>(hats);
            Queue<int> scarfQueue = new Queue<int>(scarfs);

            List<int> listSets = new List<int>();


            while (true)
            {
                if (hatStack.Count == 0 || scarfQueue.Count == 0)
                {
                    break;
                }
                int currentHat = hatStack.Peek();
                int currentScf = scarfQueue.Peek();

                if (currentHat > currentScf)
                {
                    int seT = currentHat + currentScf;
                    listSets.Add(seT);
                    hatStack.Pop();
                    scarfQueue.Dequeue();
                }
                else if (currentHat < currentScf)
                {
                    hatStack.Pop();
                }
                else
                {
                    scarfQueue.Dequeue();
                    hatStack.Pop();
                    currentHat = currentHat + 1;
                    hatStack.Push(currentHat);
                }

            }

            int mostExpensiveOne = 0;

            foreach (var s in listSets)
            {
                if (s > mostExpensiveOne)
                {
                    mostExpensiveOne = s;
                }
            }

            Console.WriteLine("The most expensive set is: {0}", mostExpensiveOne);
            Console.WriteLine(String.Join(" ", listSets));
        }
    }
}
