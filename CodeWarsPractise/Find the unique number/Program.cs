using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        return numbers.GroupBy(x => x).FirstOrDefault(x => x.Count() == 1).Key;
    }
}