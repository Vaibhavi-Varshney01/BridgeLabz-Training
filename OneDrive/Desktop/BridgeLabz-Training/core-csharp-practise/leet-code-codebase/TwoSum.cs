using System;
class TwoSum
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        bool found = false;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    Console.WriteLine("Two numbers are: " + nums[i] + " and " + nums[j]);
                    found = true;
                    break;
                }
            }

            if (found)
                break;
        }

        if (!found)
        {
            Console.WriteLine("No pair found with the given target.");
        }
    }
}
