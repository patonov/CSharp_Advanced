using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string car = Console.ReadLine();

            int count = 0;
            var queueOfCars = new Queue<string>();

            while (car != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queueOfCars.Count > 0)
                        {
                            Console.WriteLine("{0} passed!", queueOfCars.Dequeue());
                            count++;
                        }
                    }

                }
                else
                {
                    queueOfCars.Enqueue(car);
                }

                car = Console.ReadLine();
            }
            Console.WriteLine("{0} cars passed the crossroads.", count);
        }
    }
}
