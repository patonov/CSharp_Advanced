using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothsInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            var clothsStack = new Stack<int>(clothsInBox);
            int clothValue = 0;
            int counter = 1;


            while (clothsStack.Count > 0)
            {
                clothValue += clothsStack.Peek();
                if (clothValue <= rackCapacity)
                {
                    clothsStack.Pop();
                }
                else
                {
                    counter++;
                    clothValue = 0;
                }

            }
            Console.WriteLine(counter);
        }
    }
}
