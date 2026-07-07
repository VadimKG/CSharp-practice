using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        string new_str = "";
        for (int i = 0; i < str.Length; i++)
        {
            switch (str[i])
            {
                case 'a':
                case 'i':
                case 'e':
                case 'o':
                case 'u':
                case 'A':
                case 'I':
                case 'E':
                case 'O':
                case 'U':
                    break;
                default:
                    new_str += str[i];
                    break;
            }
        }
        return new_str;

        //string new_str = ""; 
        //string vowels = "aeiouAEIOU";

        //foreach(char letter in str)
        //{
        //if(!vowels.Contains(letter)) 
        // {
        //    new_str += letter;
        // }
        //}

        // return new_str;
    }
}