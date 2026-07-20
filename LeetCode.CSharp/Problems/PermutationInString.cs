namespace PermutationInString;

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        var map = new Dictionary<char, int>();
        var tmpMap = new Dictionary<char, int>();

        if (s1.Length > s2.Length)
            return false;

        foreach (var @char in s1)
        {
            if (map.ContainsKey(@char))
                map[@char] = map[@char] + 1;
            else
                map.Add(@char, 1);
        }

        for (int i = 0; i < s1.Length; i++)
        {
            if (tmpMap.ContainsKey(s2[i]))
                tmpMap[s2[i]] = tmpMap[s2[i]] + 1;
            else
                tmpMap.Add(s2[i], 1);
        }

        var isAllZeros = GetIsAllZeros(map, tmpMap);

        for (int i = s1.Length; i < s2.Length; i++)
        {
            if (isAllZeros)
                return true;

            tmpMap[s2[i - s1.Length]] = tmpMap[s2[i - s1.Length]] - 1;

            if (tmpMap.ContainsKey(s2[i]))
                tmpMap[s2[i]] = tmpMap[s2[i]] + 1;
            else
                tmpMap.Add(s2[i], 1);

            isAllZeros = GetIsAllZeros(map, tmpMap);
        }

        return isAllZeros;
    }

    private bool GetIsAllZeros(Dictionary<char, int> map, Dictionary<char, int> tmpMap)
    {
        bool isAllZeros = true;

        foreach (var (key, value) in map)
            if ((tmpMap.ContainsKey(key) ? tmpMap[key] : 0) - map[key] != 0)
                isAllZeros = false;

        return isAllZeros;
    }
}

//public class Solution
//{
//    public bool CheckInclusion(string s1, string s2)
//    {
//        var map = new Dictionary<char, int>();
//        var tmpMap = new Dictionary<char, int>();

//        if (s1.Length > s2.Length)
//            return false;

//        foreach (var @char in s1)
//        {
//            if (map.ContainsKey(@char))
//                map[@char] = map[@char] + 1;
//            else
//                map.Add(@char, 1);
//        }

//        for (int i = 0; i < s1.Length; i++)
//        {
//            if (tmpMap.ContainsKey(s2[i]))
//                tmpMap[s2[i]] = tmpMap[s2[i]] + 1;
//            else
//                tmpMap.Add(s2[i], 1);
//        }

//        var isAllZeros = GetIsAllZeros(map, tmpMap);

//        for (int i = s1.Length; i < s2.Length; i++)
//        {
//            if (isAllZeros)
//                return true;

//            tmpMap[s2[i - s1.Length]] = tmpMap[s2[i - s1.Length]] - 1;

//            if (tmpMap.ContainsKey(s2[i]))
//                tmpMap[s2[i]] = tmpMap[s2[i]] + 1;
//            else
//                tmpMap.Add(s2[i], 1);

//            isAllZeros = GetIsAllZeros(map, tmpMap);
//        }

//        return isAllZeros;
//    }

//    private bool GetIsAllZeros(Dictionary<char, int> map, Dictionary<char, int> tmpMap)
//    {
//        bool isAllZeros = true;

//        foreach (var (key, value) in map)
//            if ((tmpMap.ContainsKey(key) ? tmpMap[key] : 0) - map[key] != 0)
//                isAllZeros = false;

//        return isAllZeros;
//    }
//}