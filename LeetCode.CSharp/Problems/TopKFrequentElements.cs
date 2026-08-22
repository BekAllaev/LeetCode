namespace TopKFrequentElements;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> map = new();
        List<int>[] buckets = new List<int>[nums.Length];
        List<int> result = new();

        foreach (var item in nums)
            if (map.ContainsKey(item))
                map[item]++;
            else
                map.Add(item, 1);

        foreach (var item in map)
        {
            if (buckets[item.Value - 1] is null)
                buckets[item.Value - 1] = new List<int>();

            buckets[item.Value - 1].Add(item.Key);
        }

        for (int i = buckets.Length - 1; i >= 0; i--)
            if (buckets[i] is not null)
                result.AddRange(buckets[i]);

        return result.Take(k).ToArray();
    }
}