namespace HappyNumber;

// Super beatiful solution. Runs for 0ms too
public class Solution
{
    private int GetNext(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            int reminder = sum % 10;
            num /= 10;
            sum += reminder * reminder;
        }

        return num;
    }

    public bool IsHappy(int n)
    {
        int fast = n, slow = n;

        do
        {
            slow = GetNext(slow);
            fast = GetNext(GetNext(fast));
        }
        while (fast != slow);

        return fast == 1;
    }
}

//public class Solution
//{
//    // Accepted solution that runs for 0ms. Time complexity is O(log(n)) too,
//    // but space complexity is O(1)
//    public bool IsHappy(int n)
//    {
//        int slow = 0, fast = 0;
//        slow = GetNext(n);
//        fast = GetNext(GetNext(slow));

//        for (int i = 0; fast != slow || fast == 1; i++)
//        {
//            slow = GetNext(slow);
//            fast = GetNext(GetNext(fast));

//            if (fast == slow && fast != 1)
//                break;
//            else if (fast == 1)
//                return true;
//        }

//        return false;
//    }

//    private int GetNext(int quotient)
//    {
//        var sum = 0;
//        (quotient, sum) = GetSum(quotient, sum);

//        while (quotient >= 10)
//            (quotient, sum) = GetSum(quotient, sum);

//        sum += quotient * quotient;

//        return sum;
//    }

//    private (int quotient, int sum) GetSum(int quotient, int sum)
//    {
//        var reminder = quotient % 10;
//        quotient = quotient / 10;
//        sum += reminder * reminder;

//        return (quotient, sum);
//    }
//}

// Accepted solution that runs for time complexity - O(log(n)) and space complexity - O(log(n))
// Number of digits in "n" is log(n). Very soon, even if number is too big, we go to three digit number and we stick there
// The max digit is 9 and we can have max - 9^2 * 3 = 243 digits which is O(1) operation
// So time complexity is the cost of the bigest first operation - O(log(n))
//public class Solution
//{
//    public bool IsHappy(int n)
//    {
//        var @checked = new HashSet<int>();
//        int quotient = n, sum = 0;

//        while (!@checked.Contains(quotient))
//        {
//            @checked.Add(quotient);

//            (quotient, sum) = GetSum(quotient, sum);

//            while (quotient >= 10)
//                (quotient, sum) = GetSum(quotient, sum);

//            sum += quotient * quotient;

//            if (sum == 1)
//                return true;

//            quotient = sum;
//            sum = 0;
//        }

//        return false;
//    }

//    private (int quotient, int sum) GetSum(int quotient, int sum)
//    {
//        var reminder = quotient % 10;
//        quotient = quotient / 10;
//        sum += reminder * reminder;

//        return (quotient, sum);
//    }
//}