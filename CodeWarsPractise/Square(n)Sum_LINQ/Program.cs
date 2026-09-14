using System.Linq;
public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        var result = numbers.Select(n => n * n).Sum();
        return result;

        //int result = 0;
        //foreach (int number in numbers)
        //{
        //    result += number * number;
        //}
        //return result;
    }
}