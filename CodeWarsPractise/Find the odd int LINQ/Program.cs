using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            return seq.GroupBy(s => s).Single(r => r.Count() % 2 != 0).Key;
        }
    }
}