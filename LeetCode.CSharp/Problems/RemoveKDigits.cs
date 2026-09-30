namespace RemoveKDigits;

public class Solution
{
    // Accepted solution for 3ms
    // Here we don't use Stack abstraction, we use array of char and thus we have items already in correct order
    // top pointing to the head of the stack so we just move it
    // start pointing to the bottom of the stack so in case we have leading zeros we just move start to the point where these leading zeros ends
    // so we don't do several allocations just adjust start and top of the stack and do one string allocation. BEATIFULL SOLUTION FUHA
    public string RemoveKdigits(string num, int k)
    {
        if (k >= num.Length) return "0";
        int top = 0;
        char[] stack = new char[num.Length];

        foreach (var digit in num)
        {
            while (top > 0 && k > 0 && stack[top - 1] > digit)
            {
                top--;
                k--;
            }
            stack[top++] = digit;
        }

        top -= k;

        int start = 0;
        while (start < top && stack[start] == '0') start++;

        return start == top ? "0" : new string(stack, start, top - start);
    }

    // Accepted solution for 11ms
    //public string RemoveKdigits(string num, int k)
    //{
    //    Stack<char> stack = new();
    //    int cnt = 0;

    //    foreach (var digit in num)
    //    {
    //        while (stack.TryPeek(out var top) && top > digit && cnt < k)
    //        {
    //            stack.Pop();
    //            cnt++;
    //        }

    //        stack.Push(digit);
    //    }

    //    while (cnt < k)
    //    {
    //        stack.Pop();
    //        cnt++;
    //    }

    //    var result = new string(stack.Reverse().ToArray());
    //    result = result.TrimStart('0');
    //    return result.Length == 0 ? "0" : result;
    //}
}
