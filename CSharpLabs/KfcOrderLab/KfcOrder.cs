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
}