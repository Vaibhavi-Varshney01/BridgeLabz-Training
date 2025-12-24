using System;
class ReverseArray
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int start = 0;
        int end = arr.Length - 1;
        int temp;

        while (start < end)
        {
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }

        Console.WriteLine("Reversed Array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
