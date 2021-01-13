using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var charStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                var temp = input[i];
                charStack.Push(temp);
            }
            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
        }
    }
}
