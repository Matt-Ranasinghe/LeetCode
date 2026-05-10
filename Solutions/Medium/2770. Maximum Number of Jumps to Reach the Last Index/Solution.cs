public class Solution {
    public int MaximumJumps(int[] nums, int target) {
        int n = nums.Length;
        int[] dp = new int[n];
        for(int i = 1; i < n; i++){
            dp[i] = -1;
        }
        int result = -1;
        for(int i = 0; i < n; i++){
            if(dp[i] == -1) continue;
            int currentNum = nums[i];
            for(int j = i + 1; j < n; j++){
                int nextNum = nums[j];
                if((int)Math.Abs(currentNum - nextNum) <= target){
                    dp[j] = Math.Max(dp[i] + 1, dp[j]);
                }
            }
        }
        return dp[n - 1];
    }
}