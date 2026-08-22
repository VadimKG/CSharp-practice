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
            Monowheel monow1 = new Monowheel("MW-001", 3500, 2.0, 35);

            List<Transport> park = new List<Transport>
            {
                scooter1,
                new ElectricScooter("SC-002", 2500, 3.0, 9),
                bike1,
                new Bicycle("BC-002", 5000, 1.0, 2),
                monow1
            };

            try
            {
                Transport brokenWheel = new Monowheel("MW-002", 3500, -2.0, 35);
                park.Add(brokenWheel);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            foreach (Transport transport in park)
            {
                transport.Reserve();
            }

            Console.WriteLine($"Number of vehicles: {Transport.TotalCount}");
        } 
    }
}