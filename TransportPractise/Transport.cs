using System;
using System.Collections.Generic;
using System.Text;

namespace TransportPractise
{
    public abstract class Transport
    {
        public string ID { get; protected set; }

        public int MaxZoneRadius { get; set; }

        private double _pricePerMinute = 1.0;
        public double PricePerMinute
        {
            get
            {
                return _pricePerMinute;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine($"Minimal price: {_pricePerMinute}");
                else
                    _pricePerMinute = value;
            }
        }

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
