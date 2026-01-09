using System;
using System.Collections.Generic;
class LongestConsecutive{
    public static int FindLength(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int current = num;
                int count = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }
        return longest;
    }
}
