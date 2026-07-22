public class Kata
{
    public static int[] SortNumbers(int[] nums)
    {
        int sort = 0;

        if (nums == null)
            return new int[0];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    sort = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = sort;
                }
            }
        }
        return nums;
    }
}