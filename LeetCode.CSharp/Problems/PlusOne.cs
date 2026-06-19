namespace LeetCode.CSharp.Problems;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        bool extra = true;

        for (int i = digits.Length - 1; extra && i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                extra = true;
                digits[i] = 0;
            }
            else
            {
                extra = false;
                digits[i] = digits[i] + 1;
            }
        }

        if (!extra)
            return digits;

        int[] originalDigits = digits;
        digits = new int[digits.Length + 1];

        digits[0] = 1;

        for (int i = 0; i < originalDigits.Length; i++)
            digits[i + 1] = originalDigits[i];

        return digits;
    }
}
