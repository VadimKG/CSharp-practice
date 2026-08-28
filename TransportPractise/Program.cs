using System;
using TransportPractise;
using System.Linq;
using System.Runtime.InteropServices;

namespace TransportOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricScooter scooter1 = new ElectricScooter("SC-001", 2500, 3.0, 100);
            Bicycle bike1 = new Bicycle("BC-001", 5000, 1.0, 5);
            Monowheel wheel1 = new Monowheel("MW-001", 3500, 2.0, 35);

            List<Transport> park = new List<Transport>
            {
                scooter1,
                new ElectricScooter("SC-002", 2500, 3.0, 9),
                bike1,
                new Bicycle("BC-002", 5000, 1.0, 2),
                wheel1
            };

            var cheapTransport = park.Where(t => t.PricePerMinute < 3.0);

            Console.WriteLine("Less than 3.0 \n");
            foreach (var cht in cheapTransport)
            {
                Console.WriteLine($"Transport ID: {cht.ID} - Price: {cht.PricePerMinute}");
            }

            var sortedPark = park.OrderBy(t => t.PricePerMinute);

            Console.WriteLine("\nSort\n");
            foreach (var sp in sortedPark)
            {
                Console.WriteLine($"Transport ID: {sp.ID} - Price: {sp.PricePerMinute}");
            }

            //LINQ
            bool needsCharging = park.Any(t => t.PricePerMinute > 3.0);

            if (needsCharging)
                Console.WriteLine("Low battery! Please recharge!");

            Console.WriteLine("\n");

            var transportID = park.Select(i => i.ID);

            foreach (var catalog in transportID)
                Console.WriteLine($"List: {catalog}");

            Console.WriteLine("\n");

            int cheapVehiclesCount = park.Count(t => t.PricePerMinute < 3.0);

            Console.WriteLine($"Count of cheap transport: {cheapVehiclesCount}");

            Console.WriteLine("\n");

            var scQr = park.FirstOrDefault(q => q.ID == "SC-001");
            if (scQr != null)
                Console.WriteLine($"Your price for this: {scQr.PricePerMinute} zl/min");
            else
                Console.WriteLine("Nothing found");

            Console.WriteLine("\n");

            double totalSum = park.Sum(s => s.PricePerMinute);
            Console.WriteLine($"Total cost per minute across all rented vehicles: {totalSum}");

            Console.WriteLine("\n");

            var premVehicle = park.MaxBy(p => p.PricePerMinute);
            if(premVehicle != null)
                Console.WriteLine($"The most expensive vehicle: {premVehicle.GetType().Name} - {premVehicle.PricePerMinute} zl/min");

            Console.WriteLine("\n");

            double avPrice = park.Average(a => a.PricePerMinute);
            Console.WriteLine($"Average vehicle rental cost: {avPrice}");

            Console.WriteLine("\n");

            var sortTr = park.OrderBy(p => p.PricePerMinute).Take(2);
            Console.WriteLine("The two cheapest vehicles in the entire available fleet: ");
            foreach (var vehicle in sortTr)
            {
                Console.WriteLine($"{vehicle.GetType().Name} - {vehicle.PricePerMinute}");
            }

            Console.WriteLine("\n");

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