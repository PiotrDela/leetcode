using Xunit;

namespace LeetCode.Solutions.Tests
{
    public class _150_Evaluate_Reverse_Publish_Notation_Tests
    {
        [Theory]
        [InlineData(new string[] { "2", "1", "+", "3", "*" }, 9)]
        [InlineData(new string[] { "4", "13", "5", "/", "+" }, 6)]
        [InlineData(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
        public void Test(string[] tokens, int expectedResult)
        {
            Assert.Equal(expectedResult, new _150_Evaluate_Reverse_Publish_Notation().EvalRPN(tokens));
        }
    }
}