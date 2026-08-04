using System;

namespace KfcOrderLab
{
    class Program
    {
        static void Main(string[] args)
        {
            KfcOrder MyOrder = new KfcOrder();

            MyOrder.DishName = "Bucket of wings";
            MyOrder.Price = 15;
            MyOrder.IsReady = true;

            Console.WriteLine("--- YOUR ORDER ---\n");
            Console.WriteLine($"Dish: {MyOrder.DishName}");
            Console.WriteLine($"Price: {MyOrder.Price}");
            Console.WriteLine($"Ready?: {MyOrder.IsReady}");
        }
    }
}