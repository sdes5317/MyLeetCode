using System;

namespace MyLeetCode.Solutions
{
    public class _367_ValidPerfectSquare : _69_Sqrt_x_
    {
        // Speed100%
        //以2的n次方去搜索
        public bool IsPerfectSquare(int num)
        {
            if (num <= 1) return true;
            var sqrt = 2;
            while (Math.Pow(sqrt, 2) < num)
            {
                sqrt = GetNextSqrt(sqrt, num);
            }
            return Math.Pow(sqrt, 2) == num;
        }

        public int GetNextSqrt(int now, int score)
        {
            int res = (int)Math.Pow(now, 2);
            if (res <= score && Math.Pow(res, 2) <= score)
            {
                return (int)Math.Pow(now, 2);
            }
            return now + 1;
        }
        public bool IsPerfectSquare2(int num)
        {
            var mySqrt = MySqrt(num);
            return num == (int)Math.Pow(mySqrt, 2);
        }
    }
}