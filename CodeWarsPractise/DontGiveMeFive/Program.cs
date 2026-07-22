public class Kata
{
    public static int DontGiveMeFive(int start, int end)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            if (i.ToString().Contains("5"))
                continue;

            else
                sum++;
        }
        return sum;
    }
}