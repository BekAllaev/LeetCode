namespace PermutationInString;

// Accepted solution that runs for 3ms
// Time complexity - O(n + m). Space complexity - O(1)
public class Solution
{
    private const int Alphabet = 26;

    public bool CheckInclusion(string pattern, string text)
    {
        if (pattern.Length > text.Length)
            return false;

        var diff = new int[26];
        var zeros = Alphabet;

        foreach (var c in pattern)
            Apply(diff, c - 'a', -1, ref zeros);

        for (int i = 0; i < pattern.Length; i++)
            Apply(diff, text[i] - 'a', +1, ref zeros);

        if (zeros == Alphabet)
            return true;

        for (int i = pattern.Length; i < text.Length; i++)
        {
            Apply(diff, text[i - pattern.Length] - 'a', -1, ref zeros);
            Apply(diff, text[i] - 'a', +1, ref zeros);

            if (zeros == Alphabet)
                return true;
        }

        return false;
    }

    private void Apply(int[] diff, int index, int delta, ref int zeros)
    {
        if (diff[index] == 0)
            zeros--;

        diff[index] += delta;

        if (diff[index] == 0)
            zeros++;
    }
}

// Accepted solution that runs for 75ms
//public class Solution
//{
//    public bool CheckInclusion(string s1, string s2)
//    {
//        var map = new Dictionary<char, (int, int)>();

//        if (s1.Length > s2.Length)
//            return false;

//        foreach (var @char in s1)
//        {
//            if (map.ContainsKey(@char))
//                map[@char] = (map[@char].Item1 + 1, 0);
//            else
//                map.Add(@char, (1, 0));
//        }

//        int matches = map.Count;
//        int currentMatches = 0;

//        for (int i = 0; i < s1.Length; i++)
//        {
//            if (map.ContainsKey(s2[i]))
//            {
//                if (map[s2[i]].Item1 != map[s2[i]].Item2 && map[s2[i]].Item1 == map[s2[i]].Item2 + 1)
//                    currentMatches++;
//                else if (map[s2[i]].Item1 == map[s2[i]].Item2 && map[s2[i]].Item1 != map[s2[i]].Item2 + 1)
//                    currentMatches--;

//                map[s2[i]] = (map[s2[i]].Item1, map[s2[i]].Item2 + 1);
//            }
//        }

//        for (int i = s1.Length; i < s2.Length; i++)
//        {
//            if (matches == currentMatches)
//                return true;

//            if (map.ContainsKey(s2[i - s1.Length]))
//            {
//                if (map[s2[i - s1.Length]].Item1 == map[s2[i - s1.Length]].Item2)
//                    currentMatches--;
//                else if (map[s2[i - s1.Length]].Item1 == map[s2[i - s1.Length]].Item2 - 1)
//                    currentMatches++;

//                map[s2[i - s1.Length]] = (map[s2[i - s1.Length]].Item1, map[s2[i - s1.Length]].Item2 - 1);
//            }

//            if (map.ContainsKey(s2[i]))
//            {
//                if (map[s2[i]].Item1 != map[s2[i]].Item2 && map[s2[i]].Item1 == map[s2[i]].Item2 + 1)
//                    currentMatches++;
//                else if (map[s2[i]].Item1 == map[s2[i]].Item2)
//                    currentMatches--;

//                map[s2[i]] = (map[s2[i]].Item1, map[s2[i]].Item2 + 1);
//            }

//        }

//        return matches == currentMatches;
//    }
//}
