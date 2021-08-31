using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebration_ExamProblem
{
    class Birthday_Celebration_ExamProblem
    {
        static void Main(string[] args)
        {
            List<int> guestsEatTooMuch = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> platesForGuests = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> plateStack = new Stack<int>(platesForGuests);
            Queue<int> guestQueue = new Queue<int>(guestsEatTooMuch);
            int waste = 0;

            while (true)
            {
                var currentPlate = plateStack.Pop();

                if (currentPlate < guestQueue.Peek())
                {
                    var currentGuest = guestQueue.Dequeue();
                    currentGuest -= currentPlate;

                    while (true)
                    {
                        var lastPlate = plateStack.Pop();
                        if (lastPlate < currentGuest)
                        {
                            currentGuest -= lastPlate;
                        }
                        else
                        {
                            waste += lastPlate - currentGuest;
                            break;
                        }

                        if (plateStack.Count == 0)
                        {
                            Console.WriteLine("Guests: {0}", String.Join(" ", guestQueue));
                            Console.WriteLine("Wasted grams of food: {0}", waste);
                        }
                    }
                }

                else if (currentPlate >= guestQueue.Peek())
                {
                    waste += currentPlate - guestQueue.Peek();
                    guestQueue.Dequeue();
                }

                if (guestQueue.Count == 0)
                {
                    Console.WriteLine("Plates: {0}", String.Join(" ", plateStack));
                    Console.WriteLine("Wasted grams of food: {0}", waste);
                    return;
                }
                else if (plateStack.Count == 0)
                {
                    Console.WriteLine("Guests: {0}", String.Join(" ", guestQueue));
                    Console.WriteLine("Wasted grams of food: {0}", waste);
                    return;
                }

            }
        }
    }
}
