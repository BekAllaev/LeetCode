namespace RemoveDuplicateLetters;

public class Solution
{
    public string RemoveDuplicateLetters(string s)
    {
        int[] charIndex = new int[26];
        bool[] used = new bool[26];
        Stack<char> stack = new();

        for (int i = 0; i < s.Length; i++)
            charIndex[s[i] - 'a'] = i;

        for (int i = 0; i < s.Length; i++)
        {
            var index = s[i] - 'a';

            if (used[index])
                continue;

            while (stack.TryPeek(out var top) && top > s[i] && i <= charIndex[top - 'a'])
            {
                stack.Pop();
                used[top - 'a'] = false;
            }

            stack.Push(s[i]);
            used[index] = true;
        }

        return new string(stack.Reverse().ToArray());
    }
}
