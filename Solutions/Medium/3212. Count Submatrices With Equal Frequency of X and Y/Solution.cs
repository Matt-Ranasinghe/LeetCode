public class Solution {
    public int NumberOfSubmatrices(char[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        int[] xRatio = new int[m];
        int currentRow = 0, result = 0, xSeen = m;
        for(int j = 0; j < m; j++){
            char c = grid[0][j];
            xRatio[j] = c == 'X' ? 1 : c == 'Y' ? -1 : 0;
            if(j > 0) xRatio[j] += xRatio[j - 1];
            if(c == 'X') xSeen = Math.Min(j, xSeen);
            if(xRatio[j] == 0 && xSeen <= j) result++;
        }
        for(int i = 1; i < n; i++){
            for(int j = 0; j < m; j++){
                char c = grid[i][j];
                currentRow += (c == 'X' ? 1 : c == 'Y' ? -1 : 0);
                xRatio[j] += currentRow;
                if(c == 'X') xSeen = Math.Min(j, xSeen);
                if(xRatio[j] == 0 && xSeen <= j) result++;
            }
            currentRow = 0;
        }
        return result;
    }
}