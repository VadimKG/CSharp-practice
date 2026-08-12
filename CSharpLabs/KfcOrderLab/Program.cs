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

            DeliveryOrder myNewOrder = new DeliveryOrder("Warszawa", "Bucket of Strips", 20);
            Console.WriteLine("\n--- YOUR NEW ORDER ---\n");
            Console.WriteLine($"Adress: {myNewOrder.DeliveryAddress}");
            Console.WriteLine($"Dish: {myNewOrder.DishName}");
            Console.WriteLine($"Price: {myNewOrder.Price}");

            myNewOrder.ServeOrder();

            DeliveryOrder myBrandNewOrder = new DeliveryOrder("Szczecin", "Bucket of Bites", 11);
            Console.WriteLine("\n--- YOUR NEW ORDER ---\n");
            Console.WriteLine($"Adress: {myBrandNewOrder.DeliveryAddress}");
            Console.WriteLine($"Dish: {myBrandNewOrder.DishName}");
            Console.WriteLine($"Price: {myBrandNewOrder.Price}");

            myBrandNewOrder.PrintReceipt();
            KfcOrder.TotalCount();
        }
    }
}