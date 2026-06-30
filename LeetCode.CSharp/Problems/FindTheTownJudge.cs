namespace FindTheTownJudge;

public class Solution 
{
    // Accepted solution that runs for 1ms and beats 100% of solutions
    // I like the idea that we use iterrator as a key in the second run
    // when we looking for maximum solution

    // I want to left slower solution, so I see the difference and the progress
    public int FindJudge(int n, int[][] trust)
    {
        var arr = new int[n];

        foreach (var item in trust)
        {
            arr[item[0] - 1] -= 1;
            arr[item[1] - 1] += 1;
        }

        for (int i = 0; i < n; i++)
            if (arr[i] == n - 1)
                return i + 1;

        return -1;
    }

    // Accepted solution that runs for 18ms and beats 8% of solutions
    // public int FindJudge(int n, int[][] trust) 
    // {
    //     var vertexes = new HashSet<int>(n);
    //     var map = new Dictionary<int, int>(n);

    //     for (int i = 1; i <= n; i++)
    //     {
    //         vertexes.Add(i);
    //         map.Add(i, 0);
    //     }

    //     foreach (var item in trust)
    //     {
    //         map[item[1]] += 1;
            
    //         vertexes.Remove(item[0]);
    //     }

    //     return vertexes.Count == 1 && map[vertexes.Single()] == n-1 ? vertexes.Single() : -1;
    // }
}