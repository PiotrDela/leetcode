using Xunit;

namespace LeetCode.Solutions.Tests;

public class _290_Word_Pattern_Tests
{
    [Theory]
    [InlineData("abba", "dog cat cat dog", true)]
    [InlineData("abba", "dog cat cat fish", false)]
    [InlineData("aaaa", "dog cat cat dog", false)]
    [InlineData("abba", "dog dog dog dog", false)]
    public void Test(string pattern, string s, bool expectedOutput)
    {
        Assert.Equal(expectedOutput, new _290_Word_Pattern().WordPattern(pattern, s));
    }
}