using System.Linq;

public class Kata
{
    public static string High(string s)
    {
        return s.Split(' ').MaxBy(m => m.Sum(r => r - 96));

        //int maxScore = 0;
        //string bestWord = "";
        //int result = 0;
        //string[] new_s = s.Split(' ');

        //foreach (string word in new_s)
        //{

        //    foreach (char letter in word)
        //    {
        //        result += letter - 96;
        //    }
        //    if (result > maxScore)
        //    {
        //        maxScore = result;
        //        bestWord = word;
        //    }
        //    result = 0;
        //}
        //return bestWord;
    }
}