public class Sqrt 
{
    // This solution runs for 0ms. Time complexity is O(logN) and space complexity is O(1)

    // Trained - logic of looping, logic of narrowing the window, and overflow problem.
    public int MySqrt(int x) 
    {
        int low = 1, high = x, mid = 0;
        
        // I forgot that condition for the loop is high > low. It can be high - low > 1 or high >= low
        // I have tried last two but it didn't work so I guess it depends on the task but the main idea is like this
        while (high > low)
        {
            // I forgot basic idea of binary search. You need to keep looping and you keep updating the mid
            mid = low + (high - low) / 2;

            // Another thing I have learned is that some time int can be overflowed and you will have garbage value.
            // So consider using long. In this case CLR will updgrade lower type to higher type
            if ((long)mid * mid > x)
                // Another important thing about binary search is logic of narrowing the window. 
                // I had a problem that I didn't narrow the window and I got stuck in infinite loop. So keep in mind on logic of narrowing the window
                high = mid - 1; 
            else if ((long)mid * mid < x)
                low = mid + 1;
            else 
                return mid;
        }

        return (long)low * low > x ? low - 1 : low;
    }
}