using System;
using System.Linq;

namespace SmartHomePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SmartDevice> device = new List<SmartDevice>()
            {
                new SmartSpeaker { Name = "Apple HomePode", VolumeLevel = 50},
                new SmartLamp { Name = "Xiaomi Lamp", Brightness = 50}
            };

            foreach (var currentDevice in device)
            {
                currentDevice.TurnON();
            }
        }
    }
}