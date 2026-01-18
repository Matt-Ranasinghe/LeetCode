public class Solution {
    public int LargestMagicSquare(int[][] grid) {
        int result = 1;
        int n = grid.Length, m = grid[0].Length;
        int dimensions = Math.Min(n,m);
        for(int i = 2; i <= dimensions; i++){
            for(int j = 0; j <= n - i; j++){
                for(int k = 0; k <= m - i; k++){
                    result = Math.Max(MagicSquare(j, k, grid, i), result);
                }
            }
        }
        return result;
    }

    private int MagicSquare(int x, int y, int[][] grid, int squareSide){
        int curSum = 0, expSum = 0;
        for(int i = x; i < x + squareSide; i++){
            for(int j = y; j < y + squareSide; j++){
                curSum += grid[i][j];
            }
            if(expSum == 0) expSum =curSum;
            else if(expSum != curSum) return -1;
            curSum = 0;
        }
        for(int j = y; j < y + squareSide; j++){
            for(int i = x; i < x + squareSide; i++){
                curSum += grid[i][j];
            }
            if(expSum != curSum) return -1;
            curSum = 0;
        }
        for(int i = 0; i < squareSide; i++){
            curSum += grid[x + i][y + i];
        }
        if(expSum != curSum) return -1;
        curSum = 0;
        for(int i = 0; i < squareSide; i++){
            curSum += grid[x + squareSide - 1 - i][y + i];
        }
        if(expSum != curSum) return -1;
        return squareSide;
    }
}