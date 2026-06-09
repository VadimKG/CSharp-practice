public static class PlayAnalyzer
{
    public static string Analyze(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "Bucket of wings is ready";
            case 2:
                return "Twister is ready";
            case 3:
                return "Zinger is ready";
            default:
                return "Error!"
        }
    }
}