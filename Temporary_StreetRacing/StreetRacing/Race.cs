using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StreetRacing
{
    public class Race
    {
        private Dictionary<string, Car> Participants;
        private string name;
        private string type;
        private int laps;
        private int capacity;
        private int maxHorsePower;

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.Participants = new Dictionary<string, Car>();
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }

        public int Count => this.Participants.Count;

        public static void Add(Car car)
        {
            if (!this.Participants.ContainsKey(car.LicensePlate) &&
                this.Count < this.Capacity &&
                car.HorsePower < this.MaxHorsePower)
            {
                this.Participants.Add(car.LicensePlate, car);
            }
        }

        public static bool Remove(string licensePlate)
        {
            if (this.Participants.ContainsKey(licensePlate))
            {
                Car car = car.LicensePlate.Where(c => c.LicensePlate == licensePlate);
                this.Participants.Remove(licensePlate, car);
                return true;
            }
            return false;
        }
    }
}
