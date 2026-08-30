namespace ContigousArray;

public class Solution
{
    public int FindMaxLength(int[] nums)
    {
        Dictionary<int, int> map = new() { [0] = -1 };
        int max = 0, sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] == 0 ? -1 : 1;

            sum += nums[i];

            if (map.ContainsKey(sum))
            {
                var length = i - map[sum];

                max = length > max ? length : max;
            }
            else
                map.Add(sum, i);
        }

        return max;
    }
}