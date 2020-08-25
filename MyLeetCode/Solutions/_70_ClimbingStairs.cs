using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Solutions
{
    public class _70_ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            int[] memo = new int[n];
            return Helper(n,memo);
        }

        private int Helper(int n, int[] memo)
        {
            if (n <= 1)
            {
                return 1;
            }
            else if(memo[n - 1] == 0)
            {
                memo[n - 1] = Helper(n - 1, memo) + Helper(n - 2, memo);
                return memo[n - 1];
            }
            else
            {
                return memo[n - 1];
            }
        }
    }
}
