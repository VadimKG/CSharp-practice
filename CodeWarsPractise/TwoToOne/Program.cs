using System;
public class TwoToOne
{

    public static string Longest(string s1, string s2)
    {
        string new_s = "";
        string s3 = s1 + s2;
        char[] letters_s3 = s3.ToCharArray();
        Array.Sort(letters_s3);

        for (int i = 0; i < letters_s3.Length - 1; i++)
        {
            if (letters_s3[i] == letters_s3[i + 1])
                continue;

            else
                new_s += letters_s3[i];
        }
        new_s += letters_s3[letters_s3.Length - 1];
        return new_s;
    }
}