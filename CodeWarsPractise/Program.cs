using System;

namespace Solution
{
    public class SolutionClass
    {
        // 1. Even or Odd
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return ("Even");
            }
            else
            {
                return ("Odd");
            }
        }

        // 2. Reversed Strings
        public static string Solution(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }

        // 3. String repeat
        public static string RepeatStr(int n, string s)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += s;
            }
            return result;
        }
    }
}