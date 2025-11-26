public class Solution {
    public int NumberOfPaths(int[][] grid, int k) {
        const int MOD = (int) 1e9 + 7;
        int n = grid.Length, m = grid[0].Length;
        int[,,] dp = new int[n,m,k];
        dp[0,0,grid[0][0] % k] = 1;
        for(int i = 1; i < n; i++){
            for(int l = 0; l < k; l++){
                if(dp[i - 1,0,l] == 0) continue;
                int rem = (l + grid[i][0]) % k;
                dp[i,0,rem] = 1;
            }
        }
        for(int j = 1; j < m; j++){
             for(int l = 0; l < k; l++){
                if(dp[0,j - 1,l] == 0) continue;
                int rem = (l + grid[0][j]) % k;
                dp[0,j,rem] = 1;
            }
        }
        for(int i = 1; i < n; i++){
            for(int j = 1; j < m; j++){
                for(int l = 0; l < k; l++){
                    int rem = (l + grid[i][j]) % k;
                    dp[i,j,rem] = (dp[i - 1,j,l] + dp[i,j - 1,l]) % MOD;
                }
            }
        }
        return dp[n-1,m-1,0];
    }
}