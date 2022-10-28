using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length == 0) {
            return null;
        }

        // 将数组中第一个数字取出，值key，索引当value存入字典中
        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic.Add(nums[0], 0);

        for(int i=1; i<nums.Length; i++) {
            // 求差值，如果差值已经存在在字典中，则取出起索引，并与当前索引一起返回
            int diff = target - nums[i];
            // var idx = dic.GetValueOrDefault(diff);
            // 需要判定是否存在该key如果存在则取出value
            if(idx != null) {
                return new int[]{idx, i};
            }
        }
        return null;
    }
}