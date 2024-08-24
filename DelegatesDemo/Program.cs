using System.Linq;
using System.Collections;

namespace DelegatesDemo
{
    internal class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine()!);
            //int y = int.Parse(Console.ReadLine()!);

            //Calculate calculate = (x, y) => x + y;
            //calculate = (x, y) => x * y;

            //Console.WriteLine(calculate(x, y));

            Func<int, int, double> func = (x, y) => x / y;
            func = (x, y) => x * y;
            //Console.WriteLine(func(x, y));

            //Action<string> evenNumsPrinter = s => Console.WriteLine(s);

            //evenNumsPrinter(string.Join(" ", Console.ReadLine()!.Split().Select(n => int.Parse(n))
            //  .Where(n => n % 2 == 0)
            //.OrderBy(n => n)
            //.ToArray()
            //));

            Predicate<int> isNegative = x => x < 0;
            //Console.WriteLine(isNegative(int.Parse(Console.ReadLine()!)));

           // Console.WriteLine(string.Join(" ", Console.ReadLine()!.Split()
             //   .Select(n => int.Parse(n))
               // .Where(x => isNegative(x))
               // .ToArray()));

            Predicate<string> hasCapitalizedFirstLetter = w => w[0].ToString() == w[0].ToString().ToUpper();

            Predicate<string> hasCapitalizedLastLetter = w => char.IsUpper(w[w.Length - 1]);

            Console.WriteLine(hasCapitalizedFirstLetter(Console.ReadLine()!));
            Console.WriteLine(hasCapitalizedLastLetter(Console.ReadLine()!));



        }
    }
}
