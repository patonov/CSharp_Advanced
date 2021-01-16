using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var parentheses = Console.ReadLine();
            var firstPart = parentheses.Substring(0, parentheses.Length / 2);
            var secondPart = parentheses.Substring(parentheses.Length / 2, parentheses.Length / 2);
            var firstPartStack = new Stack<char>(firstPart);
            var secondPartQueue = new Queue<char>(secondPart);
            bool isNice = true;

            while (firstPartStack.Any())
            {
                char currentFirstPartChar = firstPartStack.Pop();
                char currentSecondPartChar = secondPartQueue.Dequeue();
                if (currentFirstPartChar == '(' && currentSecondPartChar == ')')
                {
                    continue;
                }
                else if (currentFirstPartChar == '[' && currentSecondPartChar == ']')
                {
                    continue;
                }
                else if (currentFirstPartChar == '{' && currentSecondPartChar == '}')
                {
                    continue;
                }
                else
                {
                    isNice = false;
                    break;
                }

            }
            if (isNice)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
