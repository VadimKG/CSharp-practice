using System;
using TransportPractise;

namespace TransportOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricScooter scooter1 = new ElectricScooter("SC-001", 2500, 3.0, 100);
            Bicycle bike1 = new Bicycle("BC-001", 5000, 1.0, 5);
            
            scooter1.Reserve();
            bike1.Reserve();
        }        
    }
}