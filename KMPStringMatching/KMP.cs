using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMPStringMatching
{
    internal class KMP
    {
        public void KMPAlgorithm(string T, string P)
        {
            var Pi = prefixFunction(P);

            int lonerBorder = 0;
            int totalComarisons = 0;

            for (int i = 0; i < T.Length; i++)
            {
                while (lonerBorder > 0 && P[lonerBorder] != T[i])
                {
                    lonerBorder = Pi[lonerBorder - 1];
                    totalComarisons++;
                }

                if (P[lonerBorder] == T[i])
                {
                    ++lonerBorder;
                    totalComarisons++;
                }

                if (lonerBorder == P.Length)
                {
                    Console.WriteLine($"Pattern occurs with shift {i + 1 - lonerBorder}");
                    lonerBorder = Pi[lonerBorder - 1];
                }
            }
        }

        private int[] prefixFunction(string P)
        {
            int[] pi = new int[P.Length];

            int longestBorder = 0;

            pi[1] = 0;

            for (int i = 1; i < P.Length; i++)
            {
                while (P[longestBorder] != P[i] && longestBorder > 0)
                {
                    longestBorder = pi[longestBorder - 1];
                }

                if (P[longestBorder] == P[i])
                {
                    ++longestBorder;
                }

                pi[i] = longestBorder;
            }

            return pi;
        }
    }
}
