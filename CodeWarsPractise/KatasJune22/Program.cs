using System;

namespace Solution
{
    public class Kata
    {
        //Convert a String to a Number!

        public static int StringToNumber(String str)
        {
            int.TryParse(str, out int number);
            return number;
        }

        //Return Negative

        public static int MakeNegative(int number)
        {
            return number > 0 ? -number : number;
        }
    }
}