using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] homoColorClothes = input[1].Split(',');

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < homoColorClothes.Length; j++)
                {
                    string cloth = homoColorClothes[j];
                    if (!clothes[color].ContainsKey(cloth))
                    {
                        clothes[color].Add(cloth, 0);
                    }
                    clothes[color][cloth]++;
                }
            }
            string[] clothLookedFor = Console.ReadLine().Split();
            string clothColor = clothLookedFor[0];
            string clothItem = clothLookedFor[1];

            foreach (var kvp in clothes)
            {
                Console.WriteLine("{0} clothes:", kvp.Key);
                foreach (var item in kvp.Value)
                {
                    if (kvp.Key == clothColor && item.Key == clothItem)
                    {
                        Console.WriteLine("* {0} - {1} (found!)", item.Key, item.Value);
                        continue;
                    }

                    Console.WriteLine("* {0} - {1}", item.Key, item.Value);
                }
            }
        }
    }
}
