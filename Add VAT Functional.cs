using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_VAT_Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceArr = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(n => n * 1.20).ToArray();

            foreach (var price in priceArr)
            {
                Console.WriteLine("{0:f2}", price);
            }

        }
    }
}
