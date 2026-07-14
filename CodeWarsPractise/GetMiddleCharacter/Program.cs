public class Kata
{
    public static string GetMiddle(string s)
    {
        int len = s.Length;
        int middle = 0;
        string result = "";
        middle = len / 2;

        if (s.Length % 2 == 0)
        {
            result = s[middle - 1].ToString() + s[middle].ToString();
            //result = s.Substring(middle - 1, 2);
            return result;
        }

        else
        {
            result = s[middle].ToString();
            //result = s.Substring(middle, 1);
            return result;
        }
    }
}