using Xunit;

namespace LeetCode.Solutions.Tests;

public class _88_Merge_Sorted_Array_Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] nums1, int m, int[] nums2, int n, int[] expectedOutput)
    {
        new _88_Merge_Sorted_Array().Merge(nums1, m, nums2, n);
        Assert.Equivalent(expectedOutput, nums1);
    }

    public static IEnumerable<object[]> TestData => new[]
    {
        [
            new int [] {1,2,3,0,0,0 },
            3,
            new int[] {2,5,6 },
            3,
            new int[] { 1, 2, 2, 3, 5, 6 }
        ],
        [
            new int [] {1},
            1,
            new int[0],
            0,
            new int[] {1}
        ],
        [
            new int [] {0},
            0,
            new int[] {1},
            1,
            new int[] {1}
        ],
        new object[]
        {
            new int [] {2,0},
            1,
            new int[] {1},
            1,
            new int[] {1, 2}
        }
    };
}