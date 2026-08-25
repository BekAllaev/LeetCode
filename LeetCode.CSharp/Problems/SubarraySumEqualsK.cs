namespace SubarraySumEqualsK;

public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> map = new();
        int counter = 0, sum = 0;

        map.Add(0, 1);

        foreach (var item in nums)
        {
            sum += item;

            if (map.ContainsKey(sum - k))
                counter += map[sum - k];

            if (map.ContainsKey(sum))
                map[sum]++;
            else
                map.Add(sum, 1);
        }

        return counter;
    }
}
