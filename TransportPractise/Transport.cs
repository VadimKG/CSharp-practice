using System;
using System.Collections.Generic;
using System.Text;

namespace TransportPractise
{
    public abstract class Transport
    {
        public string ID { get; protected set; }

        public int MaxZoneRadius { get; set; }

        public double PricePerMinute { get; set; }

        public Transport(string id, int maxZoneRadius, double pricePerMinute)
        {
            ID = id;
            MaxZoneRadius = maxZoneRadius;
            PricePerMinute = pricePerMinute;
        }

        public virtual void Reserve()
        {
            Console.WriteLine($"Transport {ID} had been reserved");
        }
    }
}
