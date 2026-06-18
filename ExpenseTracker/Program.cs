using System;

public static class Kata
{
    public static string Solution(string str)
    {
        string result = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }
        return result;
    }
}