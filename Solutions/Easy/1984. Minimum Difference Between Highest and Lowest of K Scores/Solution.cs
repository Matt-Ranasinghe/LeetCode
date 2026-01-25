public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        if(k == 1) return 0;
        Array.Sort(nums);
        int result = Int32.MaxValue;
        for(int i = 0; i < nums.Length - (k - 1); i++){
            result = Math.Min(result, nums[i + k - 1] - nums[i]);
        }
        return result;
    }
}