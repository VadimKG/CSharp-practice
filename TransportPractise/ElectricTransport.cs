using System;
using System.Collections.Generic;
using System.Text;

namespace TransportPractise
{
    public abstract class ElectricTransport : Transport, IChargeable
    {
        private int _batteryLevel = 100;
        public int BatteryLevel
        {
            get
            {
                return _batteryLevel;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("battery level is too low: changed to 0");
                    _batteryLevel = 0;
                }
                else if (value > 100)
                {
                    Console.WriteLine("battery level is too high: changed to 100");
                    _batteryLevel = 100;
                }
                else
                    _batteryLevel = value;
            }
        }

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
