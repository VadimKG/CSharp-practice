using System;
public class Sum
{
    public int GetSum(int a, int b)
    {
        int sum = 0;

        if (a == b)
            return a;

        else if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        else
        {
            for (int i = b; i <= a; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}