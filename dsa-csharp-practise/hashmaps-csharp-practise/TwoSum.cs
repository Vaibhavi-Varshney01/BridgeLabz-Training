using System;
using System.Collections.Generic;
class TwoSum{
    public static int[] FindIndices(int[] nums, int target){
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];

            if (map.ContainsKey(diff))
                return new int[] { map[diff], i };

            map[nums[i]] = i;
        }
        return new int[] { -1, -1 };
    }
}
