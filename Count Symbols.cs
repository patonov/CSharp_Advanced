using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<char, int> charDict = new Dictionary<char, int>();


            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (!charDict.ContainsKey(current))
                {
                    charDict.Add(current, 0);
                }
                charDict[current]++;

            }

            foreach (var symbol in charDict.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1} time/s", symbol.Key, symbol.Value);
            }


        }
    }
}
