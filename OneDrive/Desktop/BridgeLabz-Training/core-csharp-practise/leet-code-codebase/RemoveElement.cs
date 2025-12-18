using System;
class RemoveElement
{
    static void Main()
    {
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;

        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[index] = nums[i];
                index++;
            }
        }

        Console.WriteLine("New length: " + index);
        Console.WriteLine("Array after removal:");

        for (int i = 0; i < index; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}
