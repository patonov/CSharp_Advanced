using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var pumpsDetails = new Queue<string>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                pumpsDetails.Enqueue(input);
            }

            for (int i = 0; i < n; i++)
            {
                int currentPetrol = 0;
                bool isPossible = true;

                for (int j = 0; j < n; j++)
                {
                    int[] pumpData = pumpsDetails.Dequeue().Split().Select(int.Parse).ToArray();
                    pumpsDetails.Enqueue(string.Join(" ", pumpData));

                    currentPetrol += pumpData[0];
                    currentPetrol -= pumpData[1];
                    if (currentPetrol < 0)
                    {
                        isPossible = false;
                    }
                }

                if (isPossible)
                {
                    Console.WriteLine(i);
                    break;
                }

                string timeData = pumpsDetails.Dequeue();
                pumpsDetails.Enqueue(timeData);

            }
        }
    }
}
