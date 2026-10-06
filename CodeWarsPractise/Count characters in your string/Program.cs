using System.Collections.Generic;
using System;
using System.Linq;

public class Kata
{
    public static Dictionary<char, int> Count(string str)
    {
        if (str == null)
            return new Dictionary<char, int>();

        return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }
}