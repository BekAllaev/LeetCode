namespace NextGreatElementsI;

public class Solution
{
    // Solution runs for 2ms and beats 93%. Time complexity - O(n+m)
    // Space complexity - O(m) which is size of the hash table.
    // In this example I removed pre-cycle initialization. If you have pre-cycle intialization take a look - maybe your cycle covers
    // the case that you wrote in the pre-cycle initialization
    // I have removed if-else construction since if was the particular case of the cycle that was written in the Else statement.
    // I think good marker of if-else refactor candidate can be the fact that in both branches you have identical code
    // Maybe you don't even need the if-else and code can handle it without if-else. 
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var stack = new Stack<int>();
        var map = new Dictionary<int, int>();
        var result = new int[nums1.Length];

        for (int i = nums2.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && nums2[i] > stack.Peek())
                stack.Pop();

            if (stack.Count > 0)
            {
                var item = stack.Peek();
                map.Add(nums2[i], item);
            }
            else
                map.Add(nums2[i], -1);

            stack.Push(nums2[i]);
        }

        for (int i = 0; i < nums1.Length; i++)
            result[i] = map[nums1[i]];

        return result;
    }
}
