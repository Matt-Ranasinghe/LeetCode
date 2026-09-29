public class Solution {
    public bool HasValidPath(char[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        if(((n + m - 1) & 1) == 1 || grid[0][0] == ')' || grid[n - 1][m - 1] == '(') return false;
        BigInteger[,] dpGrid = new BigInteger[n,m];
        dpGrid[0,0] = 2;
        for(int i = 1; i < n; i++) {
            if(grid[i][0] == '(') dpGrid[i,0] = dpGrid[i - 1,0] << 1;
            else dpGrid[i,0] = dpGrid[i - 1,0] >> 1;
        }
        for(int j = 1; j < m; j++){
            if(grid[0][j] == '(') dpGrid[0,j] = dpGrid[0,j - 1] << 1;
            else dpGrid[0,j] = dpGrid[0,j - 1] >> 1;
        }
        for(int i = 1; i < n; i++){
            for(int j = 1; j < m; j++){
                if(grid[i][j] == '('){
                    dpGrid[i,j] = ((dpGrid[i,j - 1]) << 1) | ((dpGrid[i - 1,j]) << 1);
                }
                else{
                    dpGrid[i,j] = ((dpGrid[i,j - 1]) >> 1) | ((dpGrid[i - 1,j]) >> 1);
                }
            }
        }
        return (dpGrid[n - 1, m - 1] & 1) == 1;
    }
}