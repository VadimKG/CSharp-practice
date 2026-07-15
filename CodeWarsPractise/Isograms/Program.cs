using System;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        string l_str = str.ToLower();
        char[] letter = l_str.ToCharArray();

        for (int i = 0; i < letter.Length; i++)
        {
            for (int j = i + 1; j < letter.Length; j++)
            {
                if (letter[j] == letter[i])
                    return false;
            }
        }
        return true;
    }
}