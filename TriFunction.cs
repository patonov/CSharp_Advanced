using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int charSumTarget = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> isValid = (name, number) => name.ToCharArray()
                .Select(ch => (int)ch).Sum() >= number;

            Func<string[], int, Func<string, int, bool>, string> validName = (array, number, func) => array
                .FirstOrDefault(name => func(name, number));

            string output = validName(names, charSumTarget, isValid);
            Console.WriteLine(output);
        }
    }
}
