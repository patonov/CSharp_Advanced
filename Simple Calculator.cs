using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            var numStack = new Stack<string>(numbers.Reverse());

            while (numStack.Count > 1)
            {
                int firstNum = int.Parse(numStack.Pop());
                string sign = numStack.Pop().ToString();
                int secondNum = int.Parse(numStack.Pop());

                switch (sign)
                {
                    case "+":
                        numStack.Push((firstNum + secondNum).ToString());
                        break;
                    case "-":
                        numStack.Push((firstNum - secondNum).ToString());
                        break;
                }
            }

            Console.WriteLine(numStack.Pop());

        }
    }
}
