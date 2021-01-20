using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();


            for (int i = 0; i < input.Length; i++)
            {
                var temp = input[i];

                if (!numbers.ContainsKey(temp))
                {
                    numbers.Add(temp, 0);
                }
                numbers[temp]++;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine("{0} - {1} times", number.Key, number.Value);
            }

        }
    }
}
