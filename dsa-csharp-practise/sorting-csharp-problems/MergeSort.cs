using System;
class MergeSort {
    static void Merge(int[] arr, int l, int m, int r){
        int n1 = m - l + 1;
        int n2 = r - m;
        int[] L = new int[n1];
        int[] R = new int[n2];
        for (int i = 0; i < n1; i++)
            L[i] = arr[l + i];
        for (int j = 0; j < n2; j++)
            R[j] = arr[m + 1 + j];
        int i1 = 0, j1 = 0, k = l;
        while (i1 < n1 && j1 < n2){
            if (L[i1] <= R[j1])
                arr[k++] = L[i1++];
            else
                arr[k++] = R[j1++];
        }
        while (i1 < n1)
            arr[k++] = L[i1++];

        while (j1 < n2)
            arr[k++] = R[j1++];
    }
    static void MergeSort(int[] arr, int l, int r){
        if (l < r){
            int m = (l + r) / 2;
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);
            Merge(arr, l, m, r);
        }
    }
    static void Main(){
        int[] prices = { 450, 120, 300, 200 };
        MergeSort(prices, 0, prices.Length - 1);
        Console.WriteLine("Sorted Book Prices:");
        foreach (int p in prices)
            Console.Write(p + " ");
    }
}
