namespace Task1493;

public class Solution
{
    // Acceptedd solution for 1ms that beats 100% of solutions
    // TC - O(n)
    // SC - O(1)
    public int LongestSubarray(int[] nums)
    {
        int left = 0, distance = 0, zeros = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            zeros = nums[right] == 0 ? ++zeros : zeros; 

            if (zeros > 1)
            {
                zeros = nums[left] == 0 ? --zeros : zeros;
                left++;
            }

            distance = Math.Max(distance, right - left);
        }

        return distance;
    }

    // Accepted solution that runs for 2ms, beats 51% of solutions
    // TC - O(n)
    // SC - O(1)
    /*
    public int LongestSubarray(int[] nums)
    {
        int left = 0, right = -1, distance = 0;
        bool containsZero = false;

        while (left < nums.Length)
        {
            while (right + 1 < nums.Length && (!containsZero || nums[right + 1] != 0))
            {
                containsZero = containsZero || nums[right + 1] == 0 ? true : false;
                right++;
            }

            distance = Math.Max(distance, right - left);

            containsZero = nums[left] == 0 ? false : true;
            left++;
        }

        return distance;
    }
    */
}
