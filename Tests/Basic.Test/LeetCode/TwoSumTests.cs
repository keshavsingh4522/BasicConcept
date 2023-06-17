using LeetCode.Dictionary;

namespace Basic.Test.LeetCode;

[TestFixture]
public class TwoSumTests
{
    [TestCase(new int[] { 2, 7, 11, 15 }, new int[] { 0, 1 }, 9)]
    [TestCase(new int[] { 3, 3 }, new int[] { 0, 1 }, 6)]
    [TestCase(new int[] { 3, 3, 79, 12, 15 }, new int[] { 3, 4 }, 27)]
    [TestCase(new int[] { 3, 2, 4 }, new int[] { 1, 2 }, 6)]
    [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { 2, 4 }, -8)]
    public void Test1(int[] nums, int[] results, int target)
    {
        int[] result = TwoSum2.TwoSum(nums, target);
        int[] result2 = TwoSum2.TwoSum2nd(nums, target);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(results));
            Assert.That(result2, Is.EqualTo(results));
        });
    }
}
