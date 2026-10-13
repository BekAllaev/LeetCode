namespace Task1768;

public class Solution
{
    // Runs for 55ms
    // TC - O(n + m)
    // SC - O(n + m)
    public string MergeAlternately(string word1, string word2)
    {
        int first = 0, second = 0;
        char[] chars = new char[word1.Length + word2.Length];

        while (first < word1.Length && second < word2.Length)
        {
            chars[first + second] = word1[first++];
            chars[first + second] = word2[second++];
        }

        if (first == word1.Length)
            word2.CopyTo(second, chars, first + second, word2.Length - second);
        else
            word1.CopyTo(first, chars, first + second, word1.Length - first);

        return new string(chars);
    }
}