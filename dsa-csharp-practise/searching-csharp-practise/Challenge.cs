using System;
using System.Collections.Generic;
class Challenge{
    static int FirstMissingPositive(int[] nums){
        bool[] present = new bool[nums.Length + 1];
        foreach (int num in nums){
            if (num > 0 && num <= nums.Length)
                present[num] = true;
        }
        for (int i = 1; i < present.Length; i++)
        {
            if (!present[i])
                return i;
        }

        return nums.Length + 1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] nums = { 3, 4, -1, 1 };
        int target = 4;

        Console.WriteLine("First Missing Positive: " + FirstMissingPositive(nums));

        Array.Sort(nums);
        Console.WriteLine("Target Index: " + BinarySearch(nums, target));
    }
}
