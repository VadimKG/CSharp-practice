using System;
using System.Linq;
public static class Kata
{
    public static int MakeNegative(int number)
    {
        return new[] { number }
            .Select(n => n > 0 ? -n : n)
            .First();
        //return number > 0 ? number * -1 : number;
    }
}