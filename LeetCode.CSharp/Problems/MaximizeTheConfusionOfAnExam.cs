namespace MaximizeTheConfusionOfAnExam;

public class Solution
{
    const char T = 'T';
    const char F = 'F';

    // Accepted solution that runs for 5ms and beats 100% of solutions
    // TC - O(n)
    // SC - O(1)
    public int MaxConsecutiveAnswers(string answerKey, int k)
    {
        int left = 0, amountT = 0, distance = 0;

        for (int right = 0; right < answerKey.Length; right++)
        {
            if (answerKey[right] == T)
                amountT++;

            int amountF = right - left + 1 - amountT;
            int minFreq = Math.Min(amountT, amountF);

            // Idea of this is that once minFreq under k we are good, since we can replace untill to K elements that why we need minFreq.
            // But once minFreq more then K which means that in order to have the window that satisfies
            // the requirement we need to do more then K replacements. 
            if (minFreq > k)
            {
                if (answerKey[left] == T)
                    amountT--;
                left++;
            }

            distance = Math.Max(distance, right - left + 1);
        }

        return distance;
    }

    // Accepted solution that runs for 12ms and beats about 27% of solutions
    // TC - O(n)
    // SC - O(1)
    //public int MaxConsecutiveAnswers(string answerKey, int k)
    //{
    //    int left = 0, right = -1, distance = 0, amountT = 0, amountF = 0, maxFreq = 0;

    //    while (left < answerKey.Length)
    //    {
    //        while (right + 1 < answerKey.Length && 
    //            (right - left + 1 - maxFreq < k || 
    //                (amountT > amountF && answerKey[right + 1] == T) || 
    //                (amountT < amountF && answerKey[right + 1] == F) ||
    //                amountT == amountF))
    //        {
    //            amountT = answerKey[right + 1] == T ? ++amountT : amountT;
    //            amountF = answerKey[right + 1] == F ? ++amountF : amountF;
    //            maxFreq = Math.Max(amountT, amountF);

    //            right++;
    //        }

    //        distance = Math.Max(distance, right - left + 1);

    //        amountT = answerKey[left] == T ? --amountT : amountT;
    //        amountF = answerKey[left] == F ? --amountF : amountF;
    //        maxFreq = Math.Max(amountT, amountF);

    //        left++;
    //    }

    //    return distance;
    //}
}