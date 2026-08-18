using System;
using System.Collections.Generic;
using System.Text;

namespace TransportPractise
{
    public class ElectricScooter : Transport, IChargeable
    {
        public int BatteryLevel { get; set; }

        public ElectricScooter(string id, int maxZoneRadius, double pricePerMinute, int batteryLevel) : base(id, maxZoneRadius, pricePerMinute)
        {
            BatteryLevel = batteryLevel;
        }

        public override void Reserve()
        {
            if (BatteryLevel < 10)
                Console.WriteLine("Battery level is too low.");
            else
                base.Reserve();
        }

        public void Charge()
        {
            BatteryLevel = 100;
            Console.WriteLine("Battery is fully charge!");
        }
    }
}