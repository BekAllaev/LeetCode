namespace SubarraySumsDivisibleByK;

public class Solution
{
    // Accepted solution
    // Runs for 1ms and beats 100% solutions
    // TC - O(n)
    // SC - O(n)
    public int SubarraysDivByK(int[] nums, int k)
    {
        var arr = new int[k];
        arr[0]++;
        int counter = 0, sum = 0;

        foreach (var item in nums)
        {
            sum += item;

            var tmp = sum % k;
            var key = tmp < 0 ? tmp + k : tmp;

            counter += arr[key];
            arr[key]++;
        }

        return counter;
    }

    // Accepted solution
    // Runs for 11ms and beats 49.57% solutions
    // TC - O(n)
    // SC - O(n)
    //public int SubarraysDivByK(int[] nums, int k)
    //{
    //    Dictionary<int, int> map = new() { [0] = 1 };
    //    int counter = 0, sum = 0;

    //    foreach (var item in nums)
    //    {
    //        sum += item;

    //        var key = sum % k < 0 ? sum % k + k : sum % k;

    //        if (map.ContainsKey(key))
    //        {
    //            counter += map[key];

    //            map[key]++;
    //        }
    //        else
    //            map.Add(key, 1);
    //    }

    //    return counter;
    //}
}
