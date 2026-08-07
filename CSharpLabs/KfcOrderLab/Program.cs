using System;

namespace KfcOrderLab
{
    class Program
    {
        static void Main(string[] args)
        {
            KfcOrder myOrder = new KfcOrder("Bucket of Wings", 15);
            myOrder.Price = -100;
            Console.WriteLine("--- YOUR ORDER ---\n");
            Console.WriteLine($"Dish: {myOrder.DishName}");
            Console.WriteLine($"Price: {myOrder.Price}");
            Console.WriteLine($"Ready?: {myOrder.IsReady}");

            myOrder.ServeOrder();
        }
    }
}