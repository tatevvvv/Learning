using KMPStringMatching;

internal class Program
{
    private static void Main(string[] args)
    {
        var P = "aabaabaaab";
        var T = "aaabaabaaabaabaaabab";
        var algorithm = new KMP();

        algorithm.KMPAlgorithm(T, P);
    }
}
