using System;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        int count = 0;
        for (int i = 0; i < sheeps.Length; i++)
        {
            if (sheeps[i] == true)
            {
                count += 1;
            }

            else
            {
                continue;
            }
        }
        return count;
    }
}