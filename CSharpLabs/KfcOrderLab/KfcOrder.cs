class KfcOrder
{
	public string DishName { get; private set; }
	public bool IsReady { get; private set; }

	private int _price;

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

    public int Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (value >= 0)
                _price = value;
            else
                Console.WriteLine("Error: Price cannot be negative!");
        }
    }
}