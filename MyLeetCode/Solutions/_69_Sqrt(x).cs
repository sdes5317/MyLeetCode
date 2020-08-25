using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Solutions
{
    public class _69_Sqrt_x_
    {
        /// <summary>
        /// 這裡使用牛頓法
        /// 只需依賴除法及加法
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt(int x)
        {
            if (x <= 1) return x;

            var fxLast = (int)Math.Pow(10, GetValueLength(x)/2 +1);
            var fxNow = fxLast;

            while (Math.Pow(fxNow,2) > x)
            {
                fxNow = (fxLast + (x / fxLast)) / 2;
                fxLast = fxNow;
            }

            return fxNow;
        }

        private int GetValueLength(int x)
        {
            return x.ToString().Length;
        }
    }
}
