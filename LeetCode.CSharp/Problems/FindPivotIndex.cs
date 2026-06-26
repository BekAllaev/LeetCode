namespace FindPivotIndex;
public class Solution 
{
    public int PivotIndex(int[] nums) 
    {
        int prefix = 0, totalSum = 0;

        for (int i = 0; i < nums.Length; i++)
            totalSum += nums[i];

        for (int i = 0; i < nums.Length; i++)
        {
            totalSum -= nums[i];

            if (i != 0)
                prefix += nums[i - 1];

            if (prefix == totalSum)
                return i;
        }

        return -1;
    }
}