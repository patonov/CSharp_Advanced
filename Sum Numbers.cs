using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.WriteLine(numArr.Length);
            Console.WriteLine(numArr.Sum());

        }
    }
}
