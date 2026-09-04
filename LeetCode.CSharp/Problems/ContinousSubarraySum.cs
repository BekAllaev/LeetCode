namespace ContinousSubarraySum;

public class Solution
{
    // Solution that runs for 16ms
    // TC - O(n)
    // SC - O(n)
    public bool CheckSubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> map = new() { [0] = -1 };
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (map.ContainsKey(sum % k) && i - map[sum % k] >= 2)
                return true;
            else if (!map.ContainsKey(sum % k))
                map.Add(sum % k, i);
        }

        return false;
    }
}
