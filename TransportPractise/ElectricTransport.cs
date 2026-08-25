using System;
using System.Collections.Generic;
using System.Text;

namespace TransportPractise
{
    public abstract class ElectricTransport : Transport, IChargeable
    {
        public int BatteryLevel { get; set; }

        public void Charge()
        {
            BatteryLevel = 100;
            Console.WriteLine("Battery is fully charge!");
        }
        public ElectricTransport(string id, int maxZoneRadius, double pricePerMinute, int batteryLevel)
                                : base(id, maxZoneRadius, pricePerMinute)
        {
            BatteryLevel = batteryLevel;
        }
    }
}
