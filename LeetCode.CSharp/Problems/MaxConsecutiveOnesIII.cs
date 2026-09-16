namespace MaxConsecutiveOnesIII;

public class Solution
{
    // Accepted solution that runs for 2ms and beats 93% of solutions.
    // TC - O(n)
    // SC - O(1)
    //public int LongestOnes(int[] nums, int k)
    //{
    //    int left = 0, ones = 0, maxFreq = 0;

    //    for (int right = 0; right < nums.Length; right++)
    //    {
    //        ones = nums[right] == 1 ? ++ones : ones;

    //        maxFreq = Math.Max(maxFreq, ones);

    //        if (right - left + 1 - maxFreq > k)
    //        {
    //            ones = nums[left] == 1 ? --ones : ones;
    //            left++;
    //        }
    //    }

    //    return nums.Length - left;
    //}

    // Another accepted solution. Alternative
    // TC - O(n)
    // SC - O(1)
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0, right = 0, distance = 0, zeros = 0;

        while (left < nums.Length)
        {
            while (right + 1 < nums.Length && (nums[right + 1] == 1 || zeros < k))
            {
                zeros = nums[right] == 0 ? ++zeros : zeros;
                right++;
            }

            distance = Math.Max(distance, right - left + 1);

            zeros = nums[left] == 0 ? --zeros : zeros;
            left++;
        }

        return distance;
    }
}
