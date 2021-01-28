using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers_Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);
            var numArr = Console.ReadLine().Split(',').Select(parser).ToArray();
            Console.WriteLine(numArr.Length);
            Console.WriteLine(numArr.Sum());
        }
    }
}
