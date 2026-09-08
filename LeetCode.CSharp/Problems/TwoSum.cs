using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new();
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            var key = target - nums[i];
            if (map.ContainsKey(key))
            {
                result[0] = i;
                result[1] = map[key];

                break;
            }
            else if (!map.ContainsKey(nums[i]))
                map.Add(nums[i], i);
        }

        return result;
    }
}
