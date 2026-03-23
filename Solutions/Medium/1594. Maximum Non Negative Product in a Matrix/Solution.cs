public class Solution {
    public int MaxProductPath(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        long MOD = (long)1e9 + 7;
        long[] dpMax = new long[m];
        long[] dpMin = new long[m];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                long val = grid[i][j];
                if (i == 0 && j == 0) {
                    dpMax[j] = dpMin[j] = val;
                } 
                else 
                {
                    long choice1, choice2;
                    if (i > 0 && j > 0) {
                        long maxPrev = Math.Max(dpMax[j], dpMax[j-1]);
                        long minPrev = Math.Min(dpMin[j], dpMin[j-1]);
                        choice1 = maxPrev * val;
                        choice2 = minPrev * val;
                    } 
                    else if (i > 0) {
                        choice1 = dpMax[j] * val;
                        choice2 = dpMin[j] * val;
                    }
                    else{
                        choice1 = dpMax[j-1] * val;
                        choice2 = dpMin[j-1] * val;
                    }
                    dpMax[j] = Math.Max(choice1, choice2);
                    dpMin[j] = Math.Min(choice1, choice2);
                }
            }
        }
        long res = dpMax[m - 1];
        return res < 0 ? -1 : (int)(res % MOD);
    }
}