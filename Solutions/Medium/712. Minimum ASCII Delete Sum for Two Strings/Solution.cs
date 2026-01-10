public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        int n = s1.Length, m = s2.Length;
        int[,] dp = new int[n + 1,m + 1];
        for(int i = 0; i <= n; i++){
            for(int j = 0; j <= m; j++){
                dp[i,j] = Int32.MaxValue;
            }
        }
        dp[0,0] = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(s1[i] == s2[j]) dp[i+1,j+1] = dp[i,j];
                dp[i + 1,j] = Math.Min(dp[i,j] + (int)s1[i], dp[i + 1,j]);
                dp[i,j + 1] = Math.Min(dp[i,j] + (int)s2[j], dp[i,j + 1]);
            }
        }
        int accumulator = 0;
        for(int i = n - 1; i >= 0; i--){
            accumulator += s1[i];
            dp[i,m] += accumulator;
        }
        accumulator = 0;
        for(int j = m - 1; j >= 0; j--){
            accumulator += s2[j];
            dp[n,j] += accumulator;
        }
        for(int i = 0; i < n; i++){
            dp[i + 1,m] = Math.Min(dp[i,m], dp[i + 1,m]);
        }
        for(int j = 0; j < m; j++){
            dp[n, j + 1] = Math.Min(dp[n,j], dp[n, j + 1]);
        }
        return dp[n,m];
    }
}