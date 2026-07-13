public class Kata
{
    public static int FindShort(string s)
    {

        string[] words = s.Split(' ');
        int result = words[0].Length;

        for (int i = 0; i < words.Length; i++)
        {
            if (result > words[i].Length)
                result = words[i].Length;
        }

        //foreach(string word in words)
        //{
        //    if(result > word.Length)
        //        result = word.Length;  
        //}
        return result;
    }
}