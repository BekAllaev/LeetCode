namespace ContigousArray;

public class Solution
{
    // Time complexity - O(n)
    // Space complexity - O(n)
    // Runs for 8ms
    public int FindMaxLength(int[] nums)
    {
        int n = nums.Length;
        int[] arr = new int[2 * n + 1];
        Array.Fill(arr, int.MinValue); // instead of int.MinValue can be -2 too. 
        arr[n] = -1; // set initial value

        int max = 0, sum = 0;

        for (int i = 0; i < n; i++)
        {
            nums[i] = nums[i] == 0 ? -1 : 1;
            sum += nums[i];

            int idx = sum + n; // Value can range from -n to n, thus this formula works

            if (arr[idx] != int.MinValue)
            {
                int length = i - arr[idx];
                max = length > max ? length : max;
            }
            else
                arr[idx] = i;
        }

        return max;
    }

    // Time complexity - O(n)
    // Space complexity - O(n)
    // Runs for 12ms
    //public int FindMaxLength(int[] nums)
    //{
    //    Dictionary<int, int> map = new() { [0] = -1 };
    //    int max = 0, sum = 0;

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        nums[i] = nums[i] == 0 ? -1 : 1;

    //        sum += nums[i];

    //        if (map.ContainsKey(sum))
    //        {
    //            var length = i - map[sum];

    //            max = length > max ? length : max;
    //        }
    //        else
    //            map.Add(sum, i);
    //    }

    //    return max;
    //}
}