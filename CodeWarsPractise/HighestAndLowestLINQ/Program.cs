using System;
using System.Linq;
public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var parts = numbers.Split(' ').Select(int.Parse);

    //string num_max = parts.Max().ToString();
    //string num_min = parts.Min().ToString();

    return $"{parts.Max()} {parts.Min()}";

        //string[] words = numbers.Split(' ');

        //int highest = int.Parse(words[0]);
        //int lowest = int.Parse(words[0]);

        //foreach(string c in words)
        //{
        //  int number = int.Parse(c);

        //  if(number > highest)
        //    highest = number;

        //  if(number < lowest)
        //    lowest = number;
        //}
        //return $"{highest} {lowest}";
    }
}