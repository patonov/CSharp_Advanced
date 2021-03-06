using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> orcs = new Stack<int>();

            for (int i = 0; i < waves; i++)
            {
                var orcPowerArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (!plates.Any())
                {
                    break;
                }
                orcs = new Stack<int>(orcPowerArr);

                int attckedPlate = plates.Dequeue();

                while (true)
                {
                    var attakingOrc = orcs.Pop();
                    if (attakingOrc > attckedPlate)
                    {
                        var restOrcPower = attakingOrc - attckedPlate;
                        orcs.Push(restOrcPower);
                        attckedPlate = 0;
                        break;
                    }
                    else if (attakingOrc < attckedPlate)
                    {
                        var restPlatePower = attckedPlate - attakingOrc;
                        attckedPlate = restPlatePower;
                    }
                    else
                    {
                        var restPlatePower = attckedPlate - attakingOrc;
                        attckedPlate = restPlatePower;
                    }

                    if (orcs.Count == 0 || attckedPlate == 0)
                    {
                        break;
                    }
                }
                if (attckedPlate > 0)
                {
                    plates.Reverse();
                    plates.Enqueue(attckedPlate);
                    plates.Reverse();
                }

                if (i == 2)
                {
                    int n = int.Parse(Console.ReadLine());
                    plates.Enqueue(n);
                }
            }

            if (orcs.Count > 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine(string.Join(", ", orcs));
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine("Plates left: {0}", string.Join(", ", plates));
            }
        }
    }
}
