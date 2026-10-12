namespace Task1769;

public class Solution
{
    // Accepted solution that runs for 2ms and beats 96.88% 
    // TC - O(n)
    // SC - O(1), I guess because we don't count result array
    public int[] MinOperations(string boxes)
    {
        var answer = new int[boxes.Length];

        var balls = boxes[0] == '1' ? 1 : 0;
        for (int i = 1; i < boxes.Length; i++)
        {
            answer[i] = balls + answer[i - 1];

            if (boxes[i] == '1')
                balls++;
        }

        balls = boxes[answer.Length - 1] == '1' ? 1 : 0;
        var right = 0;
        for (int i = answer.Length - 2; i >= 0; i--)
        {
            right = balls + right;
            answer[i] = right + answer[i];

            if (boxes[i] == '1')
                balls++;
        }

        return answer;
    }
}