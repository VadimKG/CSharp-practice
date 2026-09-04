using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomePractise
{
    public struct DeviceCoordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    abstract class SmartDevice
    {
        public DeviceCoordinates Location { get; set; }
        public string? Name { get; set; }
        public bool IsOn { get; set; } = false;

        public abstract void TurnON();
    }

    class SmartSpeaker : SmartDevice
    {
        public async Task ConnectBluetoothAsync(CancellationToken token)
        {
            Console.WriteLine("Searching for Bluetooth...");
            await Task.Delay(3000, token);
            Console.WriteLine("Bluetooth connected successfully.");
        }
        public int VolumeLevel { get; private set; }

        public SmartSpeaker(string name, int initialVolume, bool isOn = false)
        {
            Name = name;
            IsOn = isOn;
            ChangeVolume(initialVolume);    
        }

        public void ChangeVolume(int newVolume)
        {
            if (newVolume > 100 || newVolume < 0)
                throw new ArgumentException("The volume must be between 0% and 100%.");

            VolumeLevel = newVolume;    
        }

        public override void TurnON()
        {
            IsOn = true;
            Console.WriteLine($"Speaker \"{Name}\" is turned on. Volume: {VolumeLevel}/100%");
        }
    }

    class SmartLamp : SmartDevice
    {
        public string BulbType { get; set; } = "SOLHETTA";
        public int Brightness { get; private set; }

        public SmartLamp(string name, int brightness, bool isOn = false)
        {
            Name = name;
            Brightness = brightness;
            IsOn = isOn;
        }
        public void ChangeBrightness(int newBrightness)
        {
            if(newBrightness > 100 || newBrightness < 0)
                throw new ArgumentException("The brightness must be between 0 and 100.");
        }
        public override void TurnON()
        {
            IsOn = true;
            Console.WriteLine($"Lamp \"{Name}\" is turned on. Brightness: {Brightness}%");
        }
    }
}