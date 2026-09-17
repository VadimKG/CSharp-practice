using System;
using System.Linq;

public class Kata
{
    public static bool All(int[] arr, Func<int, bool> fun)
    {
        return arr.All(fun);
    }
}