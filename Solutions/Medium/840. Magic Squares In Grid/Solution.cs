public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        if(n < 3 || m < 3) return 0;
        int result = 0;
        for(int i = 0; i < n - 2; i++){
            for(int j = 0; j < m - 2; j++){
                result += MagicSquare(grid, i, j) ? 1 : 0;
            }
        }
        return result;
    }

    private bool MagicSquare(int[][] grid, int x, int y){
        int tot = -1;
        bool[] seen = new bool[10];
        for(int i = x; i < x + 3; i++){
            int row = 0;
            for(int j = y; j < y + 3; j++){
                if(grid[i][j] > 9 || grid[i][j] < 1) return false;
                if(seen[grid[i][j]]) return false;
                seen[grid[i][j]] = true;
                row += grid[i][j];
            }
            if(tot == -1) tot = row;
            else if(tot != row) return false;
        }
        for(int j = y; j < y + 3; j++){
            int col = 0;
            for(int i = x; i < x + 3; i++){
                col += grid[i][j];
            }
            if(tot != col) return false;
        }
        int diagonal = 0;
        for(int i = 0; i < 3; i++){
            diagonal += grid[i + x][i + y];
        }
        if(diagonal != tot) return false;
        diagonal = 0;
        for(int i = 0; i < 3; i++){
            diagonal += grid[i + x][y - i + 2];
        }
        return diagonal == tot;
    }
}