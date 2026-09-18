using System.Linq;
public class Kata
{
    public static string[] SortByLength(string[] array)
    {
        return array.OrderBy(n => n.Length).ToArray();
    }
}