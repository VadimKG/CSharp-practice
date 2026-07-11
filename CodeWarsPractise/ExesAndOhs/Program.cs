using System.Linq;
using System;
public static class Kata
{
    public static bool XO(string input)
    {
        int count_Oo = 0;
        int count_Xx = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'o' || input[i] == 'O')
                count_Oo++;
            if (input[i] == 'x' || input[i] == 'X')
                count_Xx++;
        }

        if (count_Oo == count_Xx)
            return true;
        else
            return false;
    }
}