namespace BestTimeToBuyAndSell;

public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int max = 0, min = prices[0];

        // Idea of the algo is to keep updating not only maximum but 
        // minimum also. We want to find minimum value and each time we subtract
        // minimum value from the current value and once current value is bigger
        // than maximum, we update the maximum
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min)
                min = prices[i];

            if (prices[i] - min > max)
                max = prices[i] - min;
        }   

        return max; 
    }
}
