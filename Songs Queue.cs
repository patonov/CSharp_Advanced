using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ").ToArray();
            var songsQueue = new Queue<string>(songs);

            var command = Console.ReadLine();

            while (songsQueue.Any())
            {
                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    var songToAdd = command.Substring(4, command.Length - 4);
                    if (!songsQueue.Contains(songToAdd))
                    {
                        songsQueue.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine("{0} is already contained!", songToAdd);
                    }

                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }


                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
