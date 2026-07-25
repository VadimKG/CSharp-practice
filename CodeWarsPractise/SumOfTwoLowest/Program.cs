public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        int result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
        //Array.Sort(numbers); or bubble sort

        result = numbers[0] + numbers[1];
        return result;
    }
}