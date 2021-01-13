using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numStack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var temp = numbers[i];
                numStack.Push(temp);
            }

            var command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] commandArr = command.Split();
                string comm = commandArr[0];

                if (comm == "add")
                {
                    var numOne = int.Parse(commandArr[1]);
                    var numTwo = int.Parse(commandArr[2]);
                    numStack.Push(numOne);
                    numStack.Push(numTwo);
                }
                else if (comm == "remove")
                {
                    var whatToRemove = int.Parse(commandArr[1]);

                    if (whatToRemove <= numStack.Count)
                    {
                        for (int i = 0; i < whatToRemove; i++)
                        {
                            numStack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Sum: {0}", numStack.Sum());
        }
    }
}
