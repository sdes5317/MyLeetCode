using System;
using System.Collections.Generic;
using System.Text;
using MyLeetCode.Solutions;
using Xunit;

namespace LeetCodeTest
{
    public class UnitTest3
    {
        private _70_ClimbingStairs _solution;

        public UnitTest3()
        {
            _solution = new _70_ClimbingStairs();
        }

        [Fact]
        public void Input_3_Output_3()
        {
            Assert.Equal(3, _solution.ClimbStairs(3));
        }

        [Fact]
        public void Input_4_Output_5()
        {
            Assert.Equal(5, _solution.ClimbStairs(4));
        }

    }
}
