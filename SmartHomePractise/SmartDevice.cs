using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomePractise
{
    abstract class SmartDevice
    {
        public string? Name { get; set; }
        public bool IsOn { get; set; } = false;

        public abstract void TurnON();

    }

    class SmartSpeaker : SmartDevice
    {
        public int VolumeLevel { get; private set; } = 50;
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
        public int Brightness { get; private set; } = 80;
        public void ChangeBrightness(int newBrightness)
        {
            if(newBrightness > 100 || newBrightness < 0)
                throw new ArgumentException("The brightness must be between 0 and 100.");
        }
        public override void TurnON()
        {
            IsOn = true;
            Console.WriteLine($"Lamp \"{Name}\" is turned on. Brightnes: {Brightness}%");
        }
    }
}