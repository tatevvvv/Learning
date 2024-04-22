namespace DP
{
    internal class BuySell
    {
        // brute force, quadratic
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > maxProfit)
                    {
                        maxProfit = prices[j] - prices[i];
                    }
                }
            }

            return maxProfit;
        }

        // linear
        public int OnePass(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;

            for(int i = 0; i < prices.Length;i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }
    }
}
