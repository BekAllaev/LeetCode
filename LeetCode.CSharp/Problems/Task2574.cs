using System;
using System.Collections.Generic;
using System.Text;

namespace Task2574;

public class Solution
{
    public int[] LeftRightDifference(int[] nums)
    {
        var result = new int[nums.Length];

        var left = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = left;
            left += nums[i];
        }

        var right = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] = Math.Abs(result[i] - right);
            right = nums[i] + right;
        }

        return result;
    }
}