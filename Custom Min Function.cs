using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> minValuePrint = nums =>
            {
                int minN = int.MaxValue;

                foreach (int n in nums)
                {
                    if (n < minN)
                    {
                        minN = n;
                    }
                }

                return minN;
            };

            int result = minValuePrint(numArr);

            Console.WriteLine(result);

        }
    }
}
