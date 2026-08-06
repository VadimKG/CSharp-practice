class KfcOrder
{
	public string DishName;
	public int Price;
	public bool IsReady;

    public KfcOrder(string inputDish, int inputPrice)
    {
        DishName = inputDish;
        Price = inputPrice;
        IsReady = false;
    }

    public void ServeOrder()
    {
        IsReady = true;
        Console.WriteLine($"\nYour order \"{DishName}\" is ready!");
    }
}