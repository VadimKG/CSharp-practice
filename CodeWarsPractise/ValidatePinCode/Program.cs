using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool ValidatePin(string pin)
    {
        //return Regex.IsMatch(pin, @"^(\d{4}|\d{6})$");
        if (pin.Length != 4 && pin.Length != 6)
            return false;

        for (int i = 0; i < pin.Length; i++)
        {
            if (!char.IsDigit(pin[i]) || pin[i] < 0)
                return false;
        }

        return true;
    }
}