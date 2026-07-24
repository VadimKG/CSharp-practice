using System;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        string result = "";
        string word = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                result += word + " ";
                word = "";
            }
            else
            {
                word = str[i] + word;
            }
        }
        return result + word;
    }
}