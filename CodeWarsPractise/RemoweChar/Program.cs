using System;

public class Kata
{
    public static string Remove_char(string s)
    {
        string NewString = s.Remove(0, 1);
        string result = NewString.Remove(NewString.Length - 1, 1);
        return result;
    }
}