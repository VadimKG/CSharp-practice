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
        public int VolumeLevel { get; set; }
        public override void TurnON()
        {
            IsOn = true;
            Console.WriteLine($"Speaker \"{Name}\" is turned on. Volume: {VolumeLevel}/100");
        }
    }

    class SmartLamp : SmartDevice
    {
        public string BulbType { get; set; } = "SOLHETTA";
        public int Brightness { get; set; }
        public override void TurnON()
        {
            IsOn = true;
            Console.WriteLine($"Lamp \"{Name}\" is turned on. Brightnes: {Brightness}%");
        }
    }
}