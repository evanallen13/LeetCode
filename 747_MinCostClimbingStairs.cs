using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _747_MinCostClimbingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length == 0) return -1;
            if (cost.Length == 1) return cost[0];
            
            int l = 0;
            int r = cost.Length - 1;

            int minIndex = 0;

            while(l < r)
            {
                if (cost[l] < cost[minIndex])
                    minIndex = l;

                if (cost[r] < cost[minIndex])
                    minIndex = r;

                l++;
                r--;
            }
            return minIndex;
        }
    }
}
