using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        int min = 0;

        if (numbers.Count == 0)
            return numbers;

        else
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[min])
                    min = i;
            }
            List<int> numbers_l = numbers.ToList();
            numbers_l.RemoveAt(min);
            return numbers_l;
        }
    }
}