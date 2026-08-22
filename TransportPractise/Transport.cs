using System;
using System.Collections.Generic;
using System.Text;

namespace TransportPractise
{
    public abstract class Transport
    {
        public static int TotalCount { get; private set; }
        
        public string ID { get; protected set; }

        public int MaxZoneRadius { get; set; }

        private double _pricePerMinute;

        public double PricePerMinute
        {
            get
            {
                return _pricePerMinute;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price can not be 0 or less than 0!");
                }
                else
                {
                    _pricePerMinute = value;
                }
            }
        }

        public Transport(string id, int maxZoneRadius, double pricePerMinute)
        {
            ID = id;
            MaxZoneRadius = maxZoneRadius;
            PricePerMinute = pricePerMinute;
            TotalCount++;
        }

        public virtual void Reserve()
        {
            Console.WriteLine($"Transport {ID} had been reserved");
        }
    }
}
