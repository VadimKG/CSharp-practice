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
                new SmartSpeaker { Name = "Apple HomePode"},
                new SmartLamp { Name = "Xiaomi Lamp"}
            };

            foreach (var currentDevice in device)
            {
                currentDevice.TurnON();
            }

            try
            {
                SmartSpeaker HomePode = new SmartSpeaker { Name = "Apple HomePode 2" };
                HomePode.ChangeVolume(10);

                SmartLamp XiaomiLamp = new SmartLamp { Name = "Xiaomi Lamp" };
                XiaomiLamp.ChangeBrightness(-30);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}