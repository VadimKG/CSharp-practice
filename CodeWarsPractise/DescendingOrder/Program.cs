using System;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        string num_s = Convert.ToString(num);
        char[] num_m = num_s.ToCharArray();

        for (int i = 0; i < num_m.Length; i++)
        {
            for (int j = 0; j < num_m.Length - 1 - i; j++)
            {
                if (num_m[j] < num_m[j + 1])
                {
                    char temp = num_m[j];
                    num_m[j] = num_m[j + 1];
                    num_m[j + 1] = temp;
                }
            }
        }
        string new_s_num = new string(num_m);
        int result = int.Parse(new_s_num);
        return result;
    }
}
