namespace Task1673;

public class Solution
{
    public int[] MostCompetitive(int[] nums, int k)
    {
        int[] result = new int[k];
        int count = 0; 

        for (int i = 0; i < nums.Length; i++)
        {
            while (count > 0 && result[count - 1] > nums[i] && (count - 1) + (nums.Length - i) >= k)
                count--;

            if (count < k)
                result[count++] = nums[i];
        }

        return result;
    }
}