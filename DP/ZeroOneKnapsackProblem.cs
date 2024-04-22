namespace DP
{
    // we have objects and their profit, we should fill the knapsack with object with maximum profit. Objects are not divisible.
    // we have a capacity of knapsack
    internal class ZeroOneKnapsackProblem
    {
        // tabulation
        public int MaximumProfit(int[] weights, int capacity, int[] profits, int n)
        {
            int[,] table = new int[capacity, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < capacity; ++j)
                {
                    if (i == 0 || j == 0)
                    {
                        table[i, j] = 0;
                    }
                    if (weights[i] <= j)
                    {
                        table[i, j] = Math.Max(profits[i] + table[i - 1, j - weights[i - 1]], table[i - 1, j]);
                    }
                    else
                    {
                        table[i, j] = table[i - 1, j];
                    }
                }
            }

            // which are included
            int a = capacity;
            int b = n;

            while (a > 0 && b > 0)
            {
                if (table[a, b] == table[a - 1, b])
                {
                    Console.WriteLine("i = 0");
                    --a;
                }
                else
                {

                }
            }

            return table[n, capacity];
        }
    }
}
