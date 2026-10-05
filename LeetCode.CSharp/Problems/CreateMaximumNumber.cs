namespace CreateMaximumNumber;

public class Solution
{
    public int[] MaxNumber(int[] nums1, int[] nums2, int k)
    {
        var result = new int[k];

        int from = Math.Max(0, k - nums2.Length);
        int to = Math.Min(k, nums1.Length);

        for (int i = from; i <= to; i++)
        {
            var max1 = GetMax(nums1, i);
            var max2 = GetMax(nums2, k - i);

            var tmp = Merge(max1, max2);

            if (Greater(tmp, 0, result, 0))
                result = tmp;
        }

        return result;
    }

    private bool Greater(int[] a, int i, int[] b, int j)
    {
        while (i < a.Length && j < b.Length)
        {
            if (a[i] > b[j]) return true;
            if (a[i] < b[j]) return false;
            i++;
            j++;
        }

        return (a.Length - i) > (b.Length - j);
    }

    private int[] Merge(int[] a, int[] b)
    {
        int[] result = new int[a.Length + b.Length];
        int i = 0, j = 0;

        for (int r = 0; r < result.Length; r++)
        {
            if (Greater(a, i, b, j))
                result[r] = a[i++];
            else
                result[r] = b[j++];
        }

        return result;
    }

    public int[] GetMax(int[] nums, int k)
    {
        int[] result = new int[k];
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            while (count > 0 && result[count - 1] < nums[i] && (count - 1) + (nums.Length - i) >= k)
                count--;

            if (count < k)
                result[count++] = nums[i];
        }

        return result;
    }
}
