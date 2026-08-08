class DeliveryOrder : KfcOrder
{
    public string DeliveryAddress;

    public DeliveryOrder(string DeliveryAddress, string DishName, int Price) : base(DishName, Price)
    {
        this.DeliveryAddress = DeliveryAddress;
    }
}