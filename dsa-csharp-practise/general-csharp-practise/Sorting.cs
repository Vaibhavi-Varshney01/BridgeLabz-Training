using System;
using System.Diagnostics;

class Sorting
{
    static void Main()
    {
        int n = 10000;
        int[] data = new int[n];
        Random rand = new Random();

        // generate random data
        for (int i = 0; i < n; i++)
            data[i] = rand.Next(1, 100000);

        Stopwatch sw = new Stopwatch();

        // Bubble Sort
        int[] bubbleArray = (int[])data.Clone();
        sw.Start();
        BubbleSort(bubbleArray);
        sw.Stop();
        Console.WriteLine("Bubble Sort Time: " + sw.ElapsedMilliseconds + " ms");

        // Efficient Sort (Merge / Quick internally)
        int[] fastArray = (int[])data.Clone();
        sw.Restart();
        Array.Sort(fastArray);
        sw.Stop();
        Console.WriteLine("Merge/Quick Sort Time: " + sw.ElapsedMilliseconds + " ms");
    }

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
