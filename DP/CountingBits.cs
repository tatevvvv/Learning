namespace DP
{
    internal class CountingBits
    {
        // without memorization, O(nlogn)
        public int[] main(int n)
        {
            int[] result = new int[n];


            for (int i = 0; i <= n; ++i)
            {
                result[i] = Solve(i);

            }

            return result;
        }

        public int Solve(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            if (n % 2 == 0)
            {
                return Solve(n / 2);
            }
            else
            {
                return 1 + Solve(n / 2);
            }
        }


        // top down approach, memorization, linear
        public int[] mainMemo(int n)
        {
            int[] result = new int[n];


            for (int i = 0; i <= n; ++i)
            {
                result[i] = SolveMemo(i, result);

            }

            return result;

        }

        public int SolveMemo(int n, int[] memo)
        {
            if (memo[n] == 0)
            {
                if (n % 2 == 0)
                {
                    return Solve(n / 2);
                }
                else
                {
                    return 1 + Solve(n / 2);
                }
            }
            else
            {
                return memo[n];
            }
        }
    }
}
