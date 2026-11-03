public class Solution {
    public int UniquePaths(int[][] grid) {
        const int MOD = (int)1e9 + 7;
        int m = grid.Length;
        int n = grid[0].Length;
        int[,,] paths = new int[m, n, 2];
        paths[0, 0, 0] = 1;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (i > 0) {
                    if (grid[i - 1][j] == 0) {
                        paths[i, j, 0] = (paths[i - 1, j, 0] + paths[i - 1, j, 1]) % MOD;
                    } else {
                        paths[i, j, 0] = paths[i - 1, j, 1];
                    }
                }
                if (j > 0) {
                    if (grid[i][j - 1] == 0) {
                        paths[i, j, 1] = (paths[i, j - 1, 0] + paths[i, j - 1, 1]) % MOD;
                    } else {
                        paths[i, j, 1] = paths[i, j - 1, 0];
                    }
                }
            }
        }
        return (paths[m - 1, n - 1, 0] + paths[m - 1, n - 1, 1]) % MOD;
    }
}