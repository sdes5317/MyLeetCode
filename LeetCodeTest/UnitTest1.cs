using System;
using MyLeetCode.Solutions;
using Xunit;

namespace LeetCodeTest
{
    public class UnitTest1
    {
        private _69_Sqrt_x_ _solution;

        public UnitTest1()
        {
            _solution = new _69_Sqrt_x_();
        }

        [Fact]
        public void 零跟一的平方根為自己()
        {
            Assert.Equal(0, _solution.MySqrt(0));
            Assert.Equal(1, _solution.MySqrt(1));
        }
        [Fact]
        public void Input_4_Return_2()
        {
            Assert.Equal(2, _solution.MySqrt(4));
        }
        [Fact]
        public void Input_8192_Return_90()
        {
            Assert.Equal(90, _solution.MySqrt(8192));
        }
        [Fact]
        public void Input_2147395599_Return_46339()
        {
            Assert.Equal(46339, _solution.MySqrt(2147395599));
        }
    }
}
