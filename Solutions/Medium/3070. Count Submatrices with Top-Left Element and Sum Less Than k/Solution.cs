public class Solution {
    public int CountSubmatrices(int[][] grid, int k) {
        int n = grid.Length, m = grid[0].Length, result = 1;
        int[] cur = new int[m], sum = new int[m];
        cur[0] = grid[0][0];
        sum[0] = grid[0][0];
        if(cur[0] > k) return 0;
        for(int j = 1; j < m; j++){
            cur[j] = grid[0][j] + cur[j - 1];
            sum[j] = cur[j];
            if(cur[j] <= k) result++;
        }
        for(int i = 1; i < n; i++){
            for(int j = 0; j < m; j++){
                cur[j] = grid[i][j];
                if(j != 0){
                    cur[j] += cur[j - 1];
                }
                sum[j] += cur[j];
                if(sum[j] <= k) result++;
                else break;
            }
        }
        return result;
    }
}