using System;

namespace Transitive_Closure
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }


        void Floyd_Warshall(int n)
        {
            int[][] TransitiveMtx = new int[n][];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; ++j)
                {
                    for (int k = 0; k < n; ++k)
                    {
                        TransitiveMtx[i][j] = TransitiveMtx[i][j] | (TransitiveMtx[i][k] && TransitiveMtx[k][j]);
                    }
                }
            }
        }
    }
}
