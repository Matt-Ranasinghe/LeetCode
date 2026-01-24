public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        int result = Int32.MinValue, n = nums.Length;
        for(int i = 0; i < n / 2; i++){
            result = Math.Max(nums[i] + nums[n - i - 1], result);
        }
        return result;
    }
}