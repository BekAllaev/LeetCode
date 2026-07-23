using System.Numerics;

namespace BinaryWatch;

public class Solution 
{
    public IList<string> ReadBinaryWatch(int turnedOn) 
    {
        var result = new List<string>();

        for (int h = 0; h < 12; h++) 
        {
            for (int m = 0; m < 60; m++)  
            {
                if (BitOperations.PopCount((uint)h) + BitOperations.PopCount((uint)m) == turnedOn)
                {
                    result.Add($"{h}:{m:D2}");
                }
            }
        }

        return result;
    }
}
