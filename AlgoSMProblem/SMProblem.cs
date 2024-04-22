namespace AlgoSMProblem
{
    internal static class SMProblem
    {
        public static void Test()
        {
            var P = "aabaabaaab";
            var T = "aaabaabaaabaabaaabab";

            var deltas = compute_transition_function(P, new char[] { 'a', 'b' });

            finite_automat_matcher(T, deltas, P.Length);
        }

        private static Dictionary<int, Dictionary<char, int>> compute_transition_function(string P, char[] alphabet)
        {
            var result = new Dictionary<int, Dictionary<char, int>>();
            int m = P.Length;

            for (int q = 0; q <= m; q++)
            {
                result[q] = new Dictionary<char, int>();
                foreach (char c in alphabet)
                {
                    // since in programin everyting starts with zero, it is different from pseducode, with adding + 1 to indexes.
                    int k = Math.Min(m + 1, q + 2) - 1;
                    while (!IsSuffix(P.Take(k).ToArray(), P.Skip(q + 1 - k).Take(k - 1).Append(c).ToArray()) && k != 0)
                    {
                        k--;
                    }
                    result[q][c] = k;
                }
            }

            bool IsSuffix(char[] str1, char[] str2)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                        return false;
                }
                return true;
            }

            return result;
        }


        private static void finite_automat_matcher(string T, Dictionary<int, Dictionary<char, int>> delta, int m)
        {
            int n = T.Length;
            int q = 0;

            for (int i = 1; i < n; i++)
            {
                q = delta[q][T[i]];
                if (q == m)
                {
                    // since in programin evertying starts wwith zero, it is different from pseducode, with adding + 1 to indexes.

                    Console.WriteLine($"Pattern found with shift {i - m + 1}");
                }
            }
        }
    }
}
