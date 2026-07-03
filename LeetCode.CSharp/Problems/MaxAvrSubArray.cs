namespace MaxAvrSubArray;

public class Solution 
{
    // This solution runs for 2ms and beats 100% of solutions
    // Runs for O(n) time and O(1) space complexity
    // It is the fastest since I calculate the average only once at the end.
    public double FindMaxAverage(int[] nums, int k) 
    {
        int left = 0, right = k, maxSum = 0, tmpSum = 0;

        for (int i = 0; i < right; i++)
            maxSum += nums[i];
        tmpSum = maxSum;

        while (right < nums.Length)
        {
            tmpSum -= nums[left];
            left++;

            tmpSum += nums[right];
            right++;

            if (tmpSum > maxSum)
                maxSum = tmpSum;
        }

        return (double)maxSum / k;
    }

    // Accepted solution that works for 4ms and beats about 20% of solutions
    // Runs for O(n) time and O(1) space complexity
    // This solution is so slow because on each itteration I calculate the average
    // Whereas it is enough to find the maximum sum of k elements and just at the
    // end divide it by k. 
    // public double FindMaxAverage(int[] nums, int k) 
    // {
    //     double result = 0.0, sum = 0.0;
    //     int left = 0, right = k;

    //     for (int i = 0; i < right; i++)
    //         sum += nums[i];
    //     result = Math.Round(sum / k, 5);

    //     while (right < nums.Length)
    //     {
    //         sum -= nums[left];
    //         left++;

    //         sum += nums[right];
    //         right++;
            
    //         var cur = Math.Round(sum / k, 5);
    //         if (cur > result)
    //             result = cur;
    //     }

    //     return result;
    // }
}