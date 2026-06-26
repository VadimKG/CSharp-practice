public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        int result = 0;
        foreach (int number in numbers)
        {
            result += number * number;
        }
        return result;
    }
}