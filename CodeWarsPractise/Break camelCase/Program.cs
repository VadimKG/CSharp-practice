using System;
using System.Linq;

public class Kata
{
    public static string BreakCamelCase(string str)
    {
        return string.Concat(str.Select(s => char.IsUpper(s) ? $" {s}" : s.ToString()));
    }
}