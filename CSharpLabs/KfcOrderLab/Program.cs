using System;

namespace KfcOrderLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KfcOrder> orderHistory = new List<KfcOrder>();
            
            KfcOrder myOrder = new KfcOrder("Bucket of Wings", 15);
            //myOrder.Price = -100;
            Console.WriteLine("--- YOUR ORDER ---\n");
            Console.WriteLine($"Dish: {myOrder.DishName}");
            Console.WriteLine($"Price: {myOrder.Price}");
            Console.WriteLine($"Status: {myOrder.Status}");
            orderHistory.Add(myOrder);
            myOrder.ServeOrder();

            DeliveryOrder myNewOrder = new DeliveryOrder("Warszawa", "Bucket of Strips", 20);
            Console.WriteLine("\n--- YOUR NEW ORDER ---\n");
            Console.WriteLine($"Adress: {myNewOrder.DeliveryAddress}");
            Console.WriteLine($"Dish: {myNewOrder.DishName}");
            Console.WriteLine($"Price: {myNewOrder.Price}");
            orderHistory.Add(myNewOrder);
            myNewOrder.ServeOrder();

            DeliveryOrder myBrandNewOrder = new DeliveryOrder("Szczecin", "Bucket of Bites", 11);
            Console.WriteLine("\n--- YOUR NEW ORDER ---\n");
            Console.WriteLine($"Adress: {myBrandNewOrder.DeliveryAddress}");
            Console.WriteLine($"Dish: {myBrandNewOrder.DishName}");
            Console.WriteLine($"Price: {myBrandNewOrder.Price}");
            orderHistory.Add(myBrandNewOrder);
            myBrandNewOrder.PrintReceipt();
            KfcOrder.TotalCount();

            foreach(var order in orderHistory)
            {
                Console.WriteLine($"Dish from history: {order.DishName}");
            }
        }
    }
}