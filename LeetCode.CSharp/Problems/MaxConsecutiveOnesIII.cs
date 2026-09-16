namespace MaxConsecutiveOnesIII;

public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0, ones = 0, maxFreq = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            ones = nums[right] == 1 ? ++ones : ones;

            maxFreq = Math.Max(maxFreq, ones);

            if (right - left + 1 - maxFreq > k)
            {
                ones = nums[left] == 1 ? --ones : ones;
                left++;
            }
        }

        return nums.Length - left;
    }
}
