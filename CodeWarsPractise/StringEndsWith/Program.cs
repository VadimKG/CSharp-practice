public class Kata
{
    public static bool Solution(string str, string ending)
    {
        string tail = "";

        if (str.Length >= ending.Length)
        {
            int new_length = str.Length - ending.Length;
            tail = str.Substring(new_length);

            return tail == ending;
        }

        else
            return false;
    }
}