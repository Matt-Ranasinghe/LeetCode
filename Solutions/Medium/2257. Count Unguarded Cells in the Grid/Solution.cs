public class Solution {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {
        var grid = new int[m, n];
        foreach (var w in walls) {
            grid[w[0], w[1]] = 2;
        }
        foreach (var g in guards) {
            grid[g[0], g[1]] = 1;
        }
        int[] dx = { -1, 0, 1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        foreach (var g in guards) {
            int x = g[0], y = g[1];
            for (int d = 0; d < 4; d++) {
                int nx = x + dx[d];
                int ny = y + dy[d];
                while (nx >= 0 && nx < m && ny >= 0 && ny < n && 
                       grid[nx, ny] != 1 && grid[nx, ny] != 2) {
                    grid[nx, ny] = 3;
                    nx += dx[d];
                    ny += dy[d];
                }
            }
        }
        int count = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i, j] == 0) count++;
            }
        }
        return count;
    }
}