class Solution
{
    public static int Stray(int[] numbers)
    {
        if (numbers[0] != numbers[1])
        {
            if (numbers[0] != numbers[2])
                return numbers[0];
        }
        if (numbers[0] != numbers[1])
        {
            if (numbers[1] != numbers[2])
                return numbers[1];
        }
        if (numbers[0] == numbers[1])
        {
            if (numbers[1] != numbers[2])
                return numbers[2];
        }

        for (int i = 3; i < numbers.Length; i++)
        {
            if (numbers[0] != numbers[i])
                return numbers[i];
        }
        return numbers[0];
    }
}