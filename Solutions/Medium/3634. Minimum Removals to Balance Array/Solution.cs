public class Solution {
    public int MinRemoval(int[] nums, int k) {
        int n = nums.Length, right = 0, result = Int32.MaxValue;
        Array.Sort(nums);
        for(int i = 0; i < n; i++){
            long max = (long)nums[i] * k;
            while(right < n && nums[right] <= max){
                right++;
            }
            result = Math.Min(n - (right - i), result);
        }
        return result;
    }
}