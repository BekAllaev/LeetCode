namespace BoatsToSavePeople;

public class Solution
{
    // TODO: return the minimum number of two-person boats under the weight limit.
    public int NumRescueBoats(int[] people, int limit)
    {
        int counter = 0, left = 0, right = people.Length - 1;

        // This time I've decided to use built-in sorting algo
        Array.Sort(people);
        
        while (left <= right)
        {
            if (people[left] + people[right] <= limit)
            {
                counter++;
                left++;
                right--;
            }
            else
            {
                counter++;
                right--;
            }
        }

        return counter;
    }
}
