using System;
using System.Collections.Generic;
using System.Text;

namespace Task238;

public class Solution
{
    // Solution that runs for 1ms.
    // SC - O(1)
    // TC - O(n)
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] answer = new int[n];

        int left = 1;
        for (int i = 0; i < n; i++)
        {
            answer[i] = left;
            left *= nums[i];
        }

        int right = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] *= right;
            right *= nums[i];
        }

        return answer;
    }

    // Solution that runs for 2ms.
    // SC - O(n)
    // TC - O(n)
    // public int[] ProductExceptSelf(int[] nums) 
    // {
    //     int[] result = new int[nums.Length];
    //     int[] prefix = new int[nums.Length];
    //     int[] suffix = new int[nums.Length];

    //     prefix[0] = 1;
    //     for (int i = 1; i < nums.Length; i++)
    //         prefix[i] = nums[i - 1] * prefix[i - 1];

    //     suffix[nums.Length - 1] = 1;
    //     for (int i = nums.Length - 2; i >= 0; i--)
    //         suffix[i] = nums[i + 1] * suffix[i + 1];

    //     for (int i = 0; i < nums.Length; i++)
    //         result[i] = suffix[i] * prefix[i];

    //     return result;    
    // }
}
