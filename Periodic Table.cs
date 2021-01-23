using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            HashSet<string> chemicalSet = new HashSet<string>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    chemicalSet.Add(input[j]);
                }

            }

            foreach (var item in chemicalSet.OrderBy(x => x))
            {
                Console.Write(item + " ");
            }


        }
    }
}
