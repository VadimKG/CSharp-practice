using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        string let = "aeiou";
        return str.Count(c => let.Contains(c));

        //int vowelCount = 0;

        //foreach (char letter in str)
        //{
        //    switch (letter)
        //    {
        //        case 'a':
        //        case 'e':
        //        case 'i':
        //        case 'o':
        //        case 'u':
        //            vowelCount++;
        //            break;
        //    }
        //}

        //return vowelCount;
    }
}