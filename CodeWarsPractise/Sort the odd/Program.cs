using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        var num_odd = new Queue<int>(array.Where(x => x % 2 != 0).OrderBy(y => y));
        return array.Select(x => x % 2 != 0 ? num_odd.Dequeue() : x).ToArray();
    }
}