namespace Task1413;

public class Solution 
{
    // Accepted solution that runs for 0ms. Time complexity is O(n) and space complexity is O(1)
    public int MinStartValue(int[] nums) 
    {
        int lowest = 0, sum = 0;

        // I had here for (int i = 0).... construction
        // but it is not necessary since we need "i" only for item retrieval but we can do it with foreach cycle and write clearer code
        foreach (var item in nums)
        {
            sum += item;
            if (sum < lowest)
                lowest = sum;
        }

        // Here I had - lowest < 0 ? 1 - lowest : 1
        // but it is not necessary since when sum is positive it don't get lower then "lowest" which is 0 in this case 1 - lowest (which is 0) will be 1. And when lowest is negative 
        // it will work
        return 1 - lowest;
    }
}
