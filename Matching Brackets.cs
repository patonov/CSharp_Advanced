using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            var stackOfIndexes = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '(')
                {
                    stackOfIndexes.Push(i);
                }
                else if (numbers[i] == ')')
                {
                    int startInd = stackOfIndexes.Pop();
                    Console.WriteLine(numbers.Substring(startInd, i - startInd + 1));
                }
            }

        }
    }
}
