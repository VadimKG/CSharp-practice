class DeliveryOrder : KfcOrder
{
    public string DeliveryAddress;

    public DeliveryOrder(string DeliveryAddress, string DishName, int Price) : base(DishName, Price)
    {
        this.DeliveryAddress = DeliveryAddress;
    }

    public override void ServeOrder()
    {
        IsReady = true;
        Console.WriteLine($"\nYour order \"{DishName}\" is ready!\nThe courier has picked up the order and is already on the way to {DeliveryAddress}");
    }

    public override void PrintReceipt()
    {
        base.PrintReceipt();
        Console.WriteLine($"Address: {DeliveryAddress}");
    }
}