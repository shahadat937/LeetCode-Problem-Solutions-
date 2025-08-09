using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] a = new int[4] { 2, 7, 11, 15 };
        int target = 9;
        int[] result = solution.TwoSum(a, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}

    public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }

        throw new Exception("No solution found");
    }
}
