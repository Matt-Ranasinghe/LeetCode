public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
        int[,] dp = new int[m + 1,n + 1];
        for(int i = 0; i < m + 1; i++){
            for(int j = 0; j < n + 1; j++){
                dp[i,j] = -1;
            }
        }
        int result = 0;  
        dp[0,0] = 0;
        foreach(string str in strs){
            int ones = 0, zeroes = 0;
            foreach(char c in str){
                if(c == '1') ones++;
                else zeroes++;
            }
            for(int i = m; i >= zeroes; i--){
                for(int j = n; j >= ones; j--){
                    if(dp[i - zeroes, j - ones] != -1)
                    {
                        dp[i, j] = Math.Max(dp[i - zeroes, j - ones] + 1, dp[i, j]);
                        result = Math.Max(dp[i, j], result);
                    }
                }
            }
        }
        return result;
    }
}