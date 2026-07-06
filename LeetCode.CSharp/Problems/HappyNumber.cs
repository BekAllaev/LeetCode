namespace HappyNumber;

public class Solution
{
    public bool IsHappy(int n)
    {
        var @checked = new HashSet<int>();
        int quotient = n, sum = 0;

        while (!@checked.Contains(quotient))
        {
            @checked.Add(quotient);

            (quotient, sum) = GetSum(quotient, sum);

            while (quotient >= 10)
                (quotient, sum) = GetSum(quotient, sum);

            sum += quotient * quotient;

            if (sum == 1)
                return true;

            quotient = sum;
            sum = 0;
        }

        return false;
    }

    private (int quotient, int sum) GetSum(int quotient, int sum)
    {
        var reminder = quotient % 10;
        quotient = quotient / 10;
        sum += reminder * reminder;

        return (quotient, sum);
    }
}