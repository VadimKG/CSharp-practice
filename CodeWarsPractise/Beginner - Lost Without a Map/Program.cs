using System.Linq;

public class Kata
{
    public static int[] Maps(int[] x)
    {
        return x.Select(q => q * 2).ToArray();
    }
}