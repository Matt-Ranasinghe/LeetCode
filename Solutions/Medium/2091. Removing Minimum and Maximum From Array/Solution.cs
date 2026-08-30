public class Solution {
    public int MinimumDeletions(int[] nums) {
        int n = nums.Length;
        (int pos, int val) minimum = (-1, Int32.MaxValue), maximum = (-1, Int32.MinValue);
        for(int i = 0; i < n; i++){
            if(minimum.val > nums[i]){
                minimum = (i, nums[i]);
            }
            if(maximum.val < nums[i]){
                maximum = (i, nums[i]);
            }
        }
        int left = Math.Min(minimum.pos, maximum.pos), right = Math.Max(minimum.pos, maximum.pos);
        return Math.Min(left + 1 + n - right, Math.Min(right + 1, n - left));
    }
}