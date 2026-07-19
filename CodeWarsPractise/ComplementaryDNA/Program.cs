public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        string result = dna
          .Replace('T', '#')
          .Replace('A', 'T')
          .Replace('#', 'A')
          .Replace('C', '#')
          .Replace('G', 'C')
          .Replace('#', 'G');
        return result;

        //char[] dnaChars = dna.ToCharArray();
        //for (int i = 0; i < dnaChars.Length; i++)
        //{
        //    switch (dnaChars[i])
        //    {
        //        case 'A': dnaChars[i] = 'T'; break;
        //        case 'T': dnaChars[i] = 'A'; break;
        //        case 'C': dnaChars[i] = 'G'; break;
        //        case 'G': dnaChars[i] = 'C'; break;
        //    }
        //}
        //return new string(dnaChars);
    }
}