namespace MinimumSizeSubarraySum;

public class Solution
{
    // Accepted solution that runs for 1ms and beats 59.42% of solutions
    // TC - O(n)
    // SC - O(n)
    public int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0, right = 0, min = -1;
        int[] prefixSum = new int[nums.Length + 1];
        prefixSum[0] = 0;

        for (int i = 1; i < prefixSum.Length; i++)
            prefixSum[i] = nums[i - 1] + prefixSum[i - 1];

        while (left < nums.Length)
        {
            // sum of the subarray between left + 1 and right
            while (prefixSum[right] - prefixSum[left] < target && right < nums.Length)
                right++;

            var len = right - left;
            if (prefixSum[right] - prefixSum[left] >= target && (min == -1 || len < min))
                min = len;

            left++;
        }

        return min == -1 ? 0 : min;
    }
}
