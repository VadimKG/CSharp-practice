class KfcOrder : IReceipt
{
	public string DishName { get; private set; }
    public OrderStatus Status { get; protected set; }

	private int _price;

    public KfcOrder(string inputDish, int inputPrice)
    {
        DishName = inputDish;
        Price = inputPrice;
        Status = OrderStatus.New;
        Count++;
    }

    public virtual void ServeOrder()
    {
        Status = OrderStatus.Ready;
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

    public virtual void PrintReceipt()
    {
        Console.WriteLine($"\n\n----- THE BILL -----\n     Your order      \nDish: {DishName}\nPrice: {Price}");
    }

    private static int Count = 0;   
    public static void TotalCount()
    {
        Console.WriteLine($"\n\nTotal count of orders: {Count}");
    }
}