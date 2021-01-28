using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Uppercase_Words_Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> upperCaseChecker = n => n[0] == n.ToUpper()[0];

            var wordArr = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Where(upperCaseChecker).ToArray();

            foreach (var word in wordArr)
            {
                Console.WriteLine(word);
            }


        }
    }
}
