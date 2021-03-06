﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandArr = command.Split();
                string comm = commandArr[0];
                string position = commandArr[1];
                string argument = commandArr[2];

                Predicate<string> predicate = GetPredicate(position, argument);

                if (comm == "Remove")
                {
                    names.RemoveAll(predicate);
                }
                else if (comm == "Double")
                {
                    List<string> namesFound = names.FindAll(predicate);

                    if (namesFound.Count > 0)
                    {
                        int index = names.FindIndex(predicate);
                        names.InsertRange(index, namesFound);
                    }
                }
                command = Console.ReadLine();
            }

            if (names.Count != 0)
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string position, string argument)
        {
            if (position == "StartsWith")
            {
                return x => x.StartsWith(argument);
            }
            else if (position == "EndsWith")
            {
                return x => x.EndsWith(argument);
            }
            else if (position == "Length")
            {
                return x => x.Length == int.Parse(argument);
            }
            else
            {
                throw new ArgumentException("Invalid command type: " + position);
            }
        }
    }
}
