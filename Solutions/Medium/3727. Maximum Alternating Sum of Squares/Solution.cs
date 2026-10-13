public class Solution {
    public long MaxAlternatingSum(int[] nums) {
        Array.Sort(nums, (x, y) => Math.Abs(x).CompareTo(Math.Abs(y)));
        int n = nums.Length;
        long subtraction = 0;
        long result = 0;
        for(int i = 0; i < n/2; i++) subtraction += nums[i] * nums[i];
        for(int i = n/2; i < n; i++) result += nums[i] * nums[i];
        return result - subtraction;
    }
}