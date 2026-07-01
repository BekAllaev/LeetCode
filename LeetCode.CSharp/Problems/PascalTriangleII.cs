public class Solution 
{
    // Accepted solution that also runs for 0ms but uses less memory. Uses O(rowIndex) memeory.
    // But both solutions runs for O(n^2), since on every iterration we do one more operation. This arithmetic progression which gives us n^2 operations.
    public IList<int> GetRow(int rowIndex)
    {
        var result = new List<int>(new int[rowIndex + 1]);
        result[0] = 1;

        for (int i = 1; i <= rowIndex; i++)
            for (int j = i; j > 0; j--)
                result[j] = result[j] + result[j - 1];

        return result;
    }

    // Accepted solution that runs for 0ms. 
    // public IList<int> GetRow(int rowIndex)
    // {
    //     var result = new List<int>(1);
    //     result.Add(1);

    //     for (int i = 1; i <= rowIndex; i++)
    //     {
    //         var prev = result;
    //         result = new List<int>(prev.Count + 1);

    //         result.Add(1);

    //         for (int j = 1; j < prev.Count; j++)
    //             result.Add(prev[j - 1] + prev[j]);

    //         result.Add(1);
    //     }

    //     return result;    
    // }
}
