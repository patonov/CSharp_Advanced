using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            names = names.Where(name => name.Length <= length).ToList();

            Action<List<string>> print = ns => Console.WriteLine(string.Join(Environment.NewLine, ns));

            print(names);
                

        }
    }
}
