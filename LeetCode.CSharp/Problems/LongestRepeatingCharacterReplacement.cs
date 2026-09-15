namespace LongestRepeatingCharacterReplacement;

public class Solution
{
    // Accepted solution for 1ms
    // TC - O(n)
    // SC - O(1)
    public int CharacterReplacement(string s, int k)
    {
        const char A = 'A';
        int left = 0, maxFreq = 0;
        int[] arr = new int[26];

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            arr[c - A]++;

            maxFreq = Math.Max(maxFreq, arr[c - A]);

            if (right - left + 1 - maxFreq > k)
            {
                arr[s[left] - A]--;
                left++;
            }
        }

        return s.Length - left;
    }
}