using System;
class FirstLastOccurrence{
    static int FindFirst(int[] arr, int target){
        int low = 0, high = arr.Length - 1, result = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                high = mid - 1;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return result;
    }
    static int FindLast(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, result = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                low = mid + 1;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return result;
    }
    static void Main()
    {
        int[] arr = { 1, 2, 2, 2, 3, 4 };
        int target = 2;

        Console.WriteLine("First Occurrence: " + FindFirst(arr, target));
        Console.WriteLine("Last Occurrence: " + FindLast(arr, target));
    }
}
