using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace SmartHomePractise
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<SmartDevice> device = new List<SmartDevice>()
            {
                new SmartSpeaker ("Apple HomePode", 30, false),
                new SmartSpeaker ("Samsung HomePode", 95, true),
                new SmartSpeaker ("Xiaomi HomePode", 15, true),
                new SmartLamp ("Xiaomi Lamp", 10, false),
                new SmartLamp ("Apple Lamp", 45, true)
            };

            var activeDevice = device
                .Where(d => d.IsOn)
                .OrderBy(a => a.Name).ToList();
            foreach (var sortDevice in activeDevice)
            {
                Console.WriteLine($"Active devices: {sortDevice.Name}");
            }
            Console.WriteLine("\n");

            int activeCount = activeDevice.Count();
            Console.WriteLine($"Count of active devices: {activeCount}");

            var loudestSpeaker = device.OfType<SmartSpeaker>().MaxBy(l => l.VolumeLevel);
            Console.WriteLine($"The loudest speaker is {loudestSpeaker?.Name}");

            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(1000);

            try
            {
                await loudestSpeaker!.ConnectBluetoothAsync(cts.Token);
            }
            catch(TaskCanceledException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }





            //foreach (var currentDevice in device)
            //{
            //    currentDevice.TurnON();
            //}

            //try
            //{
            //    SmartSpeaker HomePode = new SmartSpeaker ("Apple HomePode", 30, false);
            //    HomePode.ChangeVolume(150);

            //    SmartLamp XiaomiLamp = new SmartLamp("Xiaomi Lamp", 10, false);
            //    XiaomiLamp.ChangeBrightness(-30);
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
        }
    }
}