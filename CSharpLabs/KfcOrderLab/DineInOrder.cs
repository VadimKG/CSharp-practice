class DineInOrder : KfcOrder
{
    public DineInOrder(string DishName, int Price) : base(DishName, Price) { }

    public override void ServeOrder()
    {
        Status = OrderStatus.Ready;
        Console.WriteLine($"\"Order {DishName} is ready! Pick it up at the register!\"");
    }
}