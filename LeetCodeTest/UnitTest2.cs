using System;
using MyLeetCode.Solutions;
using Xunit;

namespace LeetCodeTest
{
    public class UnitTest2
    {
        private _367_ValidPerfectSquare _solution;

        public UnitTest2()
        {
            _solution = new _367_ValidPerfectSquare();
        }

        [Fact]
        public void _16_有_整數平方根()
        {
            Assert.True(_solution.IsPerfectSquare(16));
        }
        [Fact]
        public void _14_沒有_整數平方根()
        {
            Assert.False(_solution.IsPerfectSquare(14));
        }
        [Fact]
        public void _9_有_整數平方根()
        {
            Assert.True(_solution.IsPerfectSquare(9));
        }
    }
}
