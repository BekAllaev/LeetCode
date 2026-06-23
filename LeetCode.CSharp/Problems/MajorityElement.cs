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

    // This solution runs for 0ms, this is Boyer-Moore voting algorithm. Time complexity is O(n) and space complexity is O(1)
    // Intuition behind this is that "current" have a vote and if current elemet is not the same that "current"'s vote is canceled. Since some number 
    // appear more than n/2 times we are sure that other elements won't be able to close all "votes" of this majority element
    /*
    public int MajorityElement(int[] nums) 
    {
        int current = nums[0], counter = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (counter == 0)
                current = nums[i];

            if (nums[i] == current)
                counter++;
            else
                counter--;
        }

        return current;
    }
    */
}
