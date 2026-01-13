using System;
class RotationPoint{
    static void Main(){
        int[] arr = { 5, 6, 7, 1, 2, 3, 4 };
        int low = 0, high = arr.Length - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] > arr[high])
                low = mid + 1;
            else
                high = mid;
        }
        Console.WriteLine("Rotation Index: " + low);
    }
}
