using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _121_BestTimeToBuyStocks
    {
        public int MaxProfit(int[] prices)
        {

            int maxProfit = 0;
            int min = prices.Max();

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                    min = prices[i];
                else if (prices[i] - min > maxProfit)
                    maxProfit = prices[i] - min;
            }

            if (maxProfit < 0)
                return 0;

            return maxProfit;
        }
    }
}
