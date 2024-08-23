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

            Action<string> evenNumsPrinter = s => Console.WriteLine(s);

            evenNumsPrinter(string.Join(" ", Console.ReadLine()!.Split().Select(n => int.Parse(n))
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray()
                ));


        }
    }
}
