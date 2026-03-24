public class Solution {
    public int[][] ConstructProductMatrix(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        int[,] prefixSum = new int[n * m, 2];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                int reverse = (n - i - 1) * m + (m - j - 1);
                if(i == 0 && j == 0){
                    prefixSum[0, 0] = grid[0][0] % 12345;
                    prefixSum[reverse, 1] = grid[n - 1][m - 1] % 12345;
                }
                else{
                    int mult = i * m + j;
                    prefixSum[mult, 0] = (int)((long) prefixSum[mult - 1, 0] * (long)grid[i][j] % 12345);
                    prefixSum[reverse, 1] = (int)((long)prefixSum[reverse + 1, 1] * (long)grid[n - i - 1][m - j - 1] % 12345);
                }
            }
        }
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(i == 0 && j == 0){
                    grid[i][j] = prefixSum[i * m + j + 1, 1] % 12345;
                }
                else if(i == n - 1 && j == m - 1){
                    grid[i][j] = prefixSum[i * m + j - 1, 0] % 12345;
                }
                else{
                    grid[i][j] = (int)((long)prefixSum[i * m + j - 1, 0] * (long)prefixSum[i * m + j + 1, 1]  % 12345);
                }
            }
        }
        return grid;
    }
}