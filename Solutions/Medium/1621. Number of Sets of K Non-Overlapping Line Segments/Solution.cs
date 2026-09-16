public class Solution {
    public int NumberOfSets(int n, int k) {
        const int MOD = (int) 1e9 + 7;
        int[] dp = new int[n];
        int[] sum = new int[n + 1];
        for (int j = 0; j < n; j++) {
            dp[j] = 1;
            sum[j + 1] = (sum[j] + dp[j]) % MOD;
        }
        for (int i = 1; i <= k; i++) {
            dp[0] = 0;
            for (int j = 1; j < n; j++){
                dp[j] = (dp[j - 1] + sum[j]) % MOD;
            }
            for (int j = 0; j < n; j++){
                sum[j + 1] = (sum[j] + dp[j]) % MOD;
            }
        }
        return dp[n - 1];
    }
}