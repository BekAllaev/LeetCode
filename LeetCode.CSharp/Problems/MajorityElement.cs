using System;
using System.Collections.Generic;

public class Solution 
{
    // This solution runs for 8ms and beats 53.86%. Time and space complexity - O (n)
    public int MajorityElement(int[] nums) 
    {
        int requiredNumOfApp = nums.Length / 2, result = 0;
        Dictionary<int, int> map = new (nums.Length);

        foreach (var item in nums)
            map[item] = map.ContainsKey(item) ? map[item] + 1 : 1;

        foreach (var key in map.Keys)
            if (map[key] > requiredNumOfApp)
            {
                result = key;
                break;
            }

        return result;
    }
}
