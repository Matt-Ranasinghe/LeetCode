public class Solution {
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k) {
        for (int j = x; j < x + k / 2; j++) {
            int mirrorJ = (x + (x + k - 1)) - j;
            for (int i = y; i < y + k; i++) {
                int temp = grid[j][i];
                grid[j][i] = grid[mirrorJ][i];
                grid[mirrorJ][i] = temp;
            }
        }
        return grid;
    }
}