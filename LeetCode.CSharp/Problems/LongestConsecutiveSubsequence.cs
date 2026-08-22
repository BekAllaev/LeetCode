namespace LongestConsecutiveSubsequence;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new(nums);
        int max = 0;

        foreach (var item in set)
        {
            if (!set.Contains(item - 1))
            {
                var curr = item;
                var counter = 1;

                while (set.Contains(curr + 1))
                {
                    counter++;
                    curr = curr + 1;
                }

                max = Math.Max(max, counter);
            }
        }

        return max;
    }
}