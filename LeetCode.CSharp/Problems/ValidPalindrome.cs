namespace ValidPalindrome;

public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        int left = 0, right = s.Length - 1;

        while (right > left)
        {
            while (right > left && !char.IsLetter(s[left]) && !char.IsDigit(s[left]))
                left++;
            
            while (right > left && !char.IsLetter(s[right]) && !char.IsDigit(s[right]))
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            right--;
            left++;
        }    

        return true;
    }
}
