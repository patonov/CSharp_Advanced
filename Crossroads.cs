using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightLength = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            var carsToQueue = new Queue<string>();

            int count = 0;

            string car = Console.ReadLine();

            while (car != "END")
            {
                int greenSeconds = greenLightLength;
                int passingSeconds = freeWindow;

                if (car == "green")
                {
                    while (greenSeconds > 0 && carsToQueue.Count != 0)
                    {
                        string carInQueue = carsToQueue.Dequeue();
                        greenSeconds -= carInQueue.Count();

                        if (greenSeconds >= 0)
                        {
                            count++;
                        }
                        else
                        {
                            passingSeconds += greenSeconds;

                            if (passingSeconds < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine(carInQueue + " was hit at" +
                                " " + carInQueue[carInQueue.Length + passingSeconds] + ".");
                                return;
                            }
                            count++;
                        }
                    }
                }
                else
                {
                    carsToQueue.Enqueue(car);
                }
                car = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine("{0} total cars passed the crossroads.", count);

        }
    }
}
