namespace Task1071;

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        int k = Math.Min(str1.Length, str2.Length);

        while (str1.Length % k != 0 || str2.Length % k != 0)
            k--;

        var gcd = str1.Substring(0, k);

        if (!IsValid(str1, gcd) || !IsValid(str2, gcd))
            return "";

        return gcd;
    }

    private bool IsValid(string str, string gcd)
    {
        for (int i = 0; i < str.Length; i++)
            if (str[i] != gcd[i % gcd.Length])
                return false;
        return true;
    }
}