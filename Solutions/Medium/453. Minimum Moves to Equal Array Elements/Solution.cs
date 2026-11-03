public class Solution {
    public int MinMoves(int[] nums) {
        int n = nums.Length;
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        int total = 0;
        for(int i = 0; i < n; i++){
            min = Math.Min(nums[i], min);
            max = Math.Max(nums[i], max);
            total += nums[i];
        }
        if(min == max) return 0;
        int initialMoves = max - min;
        int surplus = (total - max) - min * (n - 1);
        return initialMoves + surplus;
    }
}