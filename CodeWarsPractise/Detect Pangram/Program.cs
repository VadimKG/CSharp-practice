using System;
using System.Linq;

public static class Kata
{
    public static bool IsPangram(string str)
    {
        return str.ToLower()
                  .Where(Char.IsLetter)
                  .Distinct()
                  .Count() == 26;
    }
}