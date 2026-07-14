public class Accumul
{
    public static string Accum(string s)
    {
        string sentence = "";

        for (int i = 0; i < s.Length; i++)
        {
            char up_letter = char.ToUpper(s[i]);
            string low_letters = new string(char.ToLower(s[i]), i);
            string row = up_letter + low_letters;
            sentence += row + "-";
        }
        string result = sentence.TrimEnd('-');
        return result;
    }
}