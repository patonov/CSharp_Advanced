using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            var nameArr = Console.ReadLine().Split().ToArray();

            printNames(nameArr);

        }
    }
}
