public class Solution {
    public bool CanPartitionGrid(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        long[] vSums = new long[n], hSums = new long[m];
        long total = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                vSums[i] += grid[i][j];
                hSums[j] += grid[i][j];
                total += grid[i][j];
            }
        }
        long topSum = 0;
        for(int i = 0; i < n - 1; i++){
            topSum += vSums[i];
            if(topSum * 2 == total) return true; 
        }
        long leftSum = 0;
        for(int j = 0; j < m - 1; j++){
            leftSum += hSums[j];
            if(leftSum * 2 == total) return true;
        }
        return false;
    }
}