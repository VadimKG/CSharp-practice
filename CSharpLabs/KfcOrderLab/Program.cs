using System;

namespace KfcOrderLab
{
    class Program
    {
        static void Main(string[] args)
        {
            KfcOrder MyOrder = new KfcOrder("Bucket of Wings", 15);

            Console.WriteLine("--- YOUR ORDER ---\n");
            Console.WriteLine($"Dish: {MyOrder.DishName}");
            Console.WriteLine($"Price: {MyOrder.Price}");
            Console.WriteLine($"Ready?: {MyOrder.IsReady}");

            MyOrder.ServeOrder();
        }
    }
}