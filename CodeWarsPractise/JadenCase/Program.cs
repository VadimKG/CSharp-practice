using System;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        char[] phrase_mas = phrase.ToCharArray();
        phrase_mas[0] = char.ToUpper(phrase_mas[0]);
        for (int i = 0; i < phrase_mas.Length - 1; i++)
        {
            if (phrase_mas[i] == ' ')
                phrase_mas[i + 1] = char.ToUpper(phrase_mas[i + 1]);
        }
        string result = new string(phrase_mas);
        return result;
    }
}