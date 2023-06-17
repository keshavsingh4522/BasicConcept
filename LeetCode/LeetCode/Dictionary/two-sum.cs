namespace LeetCode.Dictionary;

/// <summary>
/// Question: https://leetcode.com/problems/two-sum/
/// Submitted Code: 
/// </summary>
public class TwoSum2
{
    // Solution 1
    public static int[] TwoSum(int[] nums, int target)
    {
        // Create a dictionary, where key is element of array and value is index number of array
        Dictionary<int, List<int>> keyValuePairs = new();

        // Store the data in dictionary O(n)
        int index = 0;
        while (index < nums.Length)
        {
            try
            {
                keyValuePairs[nums[index]].Add(index);
            }
            catch (Exception)
            {
                keyValuePairs[nums[index]] = new List<int> { index };
            }
            index++;
        }

        foreach (var value in keyValuePairs)
        {
            // Now get the index
            // Target-key = key,
            int temp = target - value.Key;
            if (temp == value.Key && keyValuePairs[value.Key].Count > 1)
                return new int[] { keyValuePairs[value.Key][0], keyValuePairs[value.Key][1] };
            bool isExist = keyValuePairs.ContainsKey(temp);
            if (isExist && (temp != value.Key))
            {
                return new int[] { keyValuePairs[value.Key][0], keyValuePairs[temp][0] };
            }
        }
        return Array.Empty<int>();
    }

    // Solution 2
    public static int[] TwoSum2nd(int[] nums, int target)
    {
        // Create a dictionary, where key is element of array and value is index number of array
        Dictionary<int, int> keyValuePairs = new();

        // Store the data in dictionary O(n)
        int index = 0;
        while (index < nums.Length)
        {
            keyValuePairs[nums[index]] = index;
            index++;
        }
        index = 0;
        while (index < nums.Length)
        {
            if (keyValuePairs.TryGetValue(target - nums[index], out int value2) && value2 != index)
            {
                return new int[] { index, value2 };
            }
            index++;
        }
        return Array.Empty<int>();
    }
}