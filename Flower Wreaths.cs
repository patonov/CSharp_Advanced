using System;
using System.Linq;
using System.Collections.Generic;

namespace Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            int wreaths = 0;
            int flowers = 0;

            while (roses.Count > 0 && lilies.Count > 0)
            {
                int lili = lilies.Pop();
                int rose = roses.Dequeue();
                int sum = lili + rose;
                if (sum == 15)
                {
                    wreaths++;
                }
                else if (sum < 15)
                {
                    flowers += sum;
                }
                else
                {
                    while (true)
                    {
                        sum -= 2;
                        if (sum == 15)
                        {
                            wreaths++;
                            break;
                        }
                        else if (sum < 15)
                        {
                            flowers += sum;
                            break;
                        }
                    }
                }
            }
            wreaths += flowers / 15;

            if (wreaths >= 5)
            {
                Console.WriteLine("You made it, you are going to the competition with {0} wreaths!", wreaths);
            }
            else
            {
                Console.WriteLine("You didn't make it, you need {0} wreaths more!", 5 - wreaths);
            }

        }
    }
}
