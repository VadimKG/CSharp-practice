using System;
using System.Linq;

public class Kata
{
    public static string DuplicateEncode(string word)
    {
        var low = word.ToLower();
        return String.Concat(low.Select(q => low.Count(u => u == q) == 1 ? '(' : ')'));
    }
}