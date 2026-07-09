using System;

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        string[] words = numbers.Split(' ');

        int highest = int.Parse(words[0]);
        int lowest = int.Parse(words[0]);

        foreach (string textNumber in words)
        {
            int number = int.Parse(textNumber);

            if (number > highest)
                highest = number;

            if (number < lowest)
                lowest = number;
        }
        return $"{highest} {lowest}";
    }
}