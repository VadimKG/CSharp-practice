using System;

public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        for (int i = 0; i < haystack.Length; i++)
        {
            if (object.Equals(haystack[i], "needle"))
                return "found the needle at position " + i;
        }
        return "needle";
    }
}