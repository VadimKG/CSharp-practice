using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TransportPractise
{
    public class Bicycle : Transport
    {
        public int TirePressure { get; set; }

        public Bicycle(string id, int maxRentZone, double pricePerMinute, int tirePressure) : base(id, maxRentZone, pricePerMinute)
        {
            TirePressure = tirePressure;
        }

        public override void Reserve()
        {
            if (TirePressure < 3)
                Console.WriteLine("The tire pressure is too low");
            else
                base.Reserve();
        }

        public void Cleaning()
        {
            Console.WriteLine($"The chain of {ID} has been cleaned");
        }
    }
}
