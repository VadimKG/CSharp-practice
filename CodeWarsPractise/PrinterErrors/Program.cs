using System;

public class Printer
{
    public static string PrinterError(String s)
    {
        int counter = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] > 'm')
                counter++;
        }
        return $"{counter}/{s.Length}";
    }
}