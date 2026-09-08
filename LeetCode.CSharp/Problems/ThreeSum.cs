namespace ThreeSum;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int start = i + 1, end = nums.Length - 1, target = nums[i] * -1;

            while (start < end)
            {
                if (nums[start] + nums[end] == target)
                {
                    result.Add([nums[i], nums[start], nums[end]]);

                    for (start++; start < nums.Length && nums[start - 1] == nums[start];)
                        start++;

                    for (end--; end > 0 && nums[end + 1] == nums[end];)
                        end--;
                }
                else if (nums[start] + nums[end] > target)
                    end--;
                else if (nums[start] + nums[end] < target)
                    start++;
            }
        }

        return result;
    }
}
