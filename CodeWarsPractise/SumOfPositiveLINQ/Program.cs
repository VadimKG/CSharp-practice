using System;
using System.Linq;
public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        return arr.Where(n => n > 0).Sum();

        //int result = 0;

        //        for (int i = 0; i < arr.Length; i++)
        //      {
        //          if (arr[i] > 0)
        //          {
        //            result += arr[i];
        //          }
        //      }
        //        return result;
    }
}