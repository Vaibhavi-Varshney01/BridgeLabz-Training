using System;
using System.Collections.Generic;
class ZeroSumSubarrays{
    public static void FindSubarrays(int[] arr){
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;
        // Sum 0 at index -1
        map[0] = new List<int> { -1 };
        for (int i = 0; i < arr.Length; i++){
            sum += arr[i];
            if (map.ContainsKey(sum)){
                foreach (int startIndex in map[sum]){
                    Console.WriteLine($"Subarray found from {startIndex + 1} to {i}");
                }
                map[sum].Add(i);
            }
            else{
                map[sum] = new List<int> { i };
            }
        }
    }
}
