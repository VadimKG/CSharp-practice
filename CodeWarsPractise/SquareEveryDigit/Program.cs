using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string sum = "";
        string s_n = n.ToString();

        for (int i = 0; i < s_n.Length; i++)
        {
            //string s_i_n = s_n[i].ToString();
            //int i_n = int.Parse(s_i_n);
            int i_n = int.Parse(s_n[i].ToString());
            sum += i_n * i_n;
        }
        //int result = Int32.Parse(sum);
        //return result;
        return Int32.Parse(sum);
    }
}