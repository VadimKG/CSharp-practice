using System;

namespace KfcOrderLab
{
    class Program
    {
        static void Main(string[] args)
        {
            KfcOrder myOrder = new KfcOrder("Bucket of Wings", 15);
            //myOrder.Price = -100;
            Console.WriteLine("--- YOUR ORDER ---\n");
            Console.WriteLine($"Dish: {myOrder.DishName}");
            Console.WriteLine($"Price: {myOrder.Price}");
            Console.WriteLine($"Ready?: {myOrder.IsReady}");

            myOrder.ServeOrder();

            DeliveryOrder myNewOrder = new DeliveryOrder("Warszawa", "Bucket of Wings", 15);
            Console.WriteLine("\n--- YOUR NEW ORDER ---\n");
            Console.WriteLine($"Adress: {myNewOrder.DeliveryAddress}");
            Console.WriteLine($"Dish: {myNewOrder.DishName}");
            Console.WriteLine($"Price: {myNewOrder.Price}");

            myNewOrder.ServeOrder();
        }
    }
}