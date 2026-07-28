namespace ContainerWithMostWater;

public class Solution
{
    public long MaxArea(int[] height)
    {
        int left = 0, right = height.Length - 1;
        long max = 0;

        while (left < right)
        {
            var currMax = (long)Math.Min(height[left], height[right]) * (right - left);
            if (currMax > max)
                max = currMax;

            if (height[left] > height[right])
                right--;
            else if (height[left] < height[right])
                left++;
            else
            {
                left++;
                right--;
            }
        }

        return max;
    }
}
