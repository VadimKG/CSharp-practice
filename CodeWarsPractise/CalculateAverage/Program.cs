class AverageSolution
{
    public static double FindAverage(double[] array)
    {
        double sum = 0;
        double result = 0;
        if (array.Length != 0)
        {
            //foreach (double number in array)
            //{
            //    sum += number;
            //}
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            result = sum / array.Length;
            return result;
        }

        else
            return 0;
    }
}