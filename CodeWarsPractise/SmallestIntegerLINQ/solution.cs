using System.Linq;
public class Kata
{
    public static int FindSmallestInt(int[] args)
    {
        return args.Min();

        //int min = args[0];
        //for(int i = 1; i < args.Length; i++)
        //{
        //  if(args[i] < min)
        //  {
        //    min = args[i];
        //  } 
        //}
        //    return min;
    }
}