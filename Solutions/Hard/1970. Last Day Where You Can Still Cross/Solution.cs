public class Solution {
    public int LatestDayToCross(int row, int col, int[][] cells) {
        int left = 1, right = cells.Length;
        int result = 0;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (CanCross(row, col, cells, mid)) {
                result = mid;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return result;
    }

    private bool CanCross(int row, int col, int[][] cells, int day) {
        int[,] grid = new int[row, col];
        for (int i = 0; i < day; i++) {
            grid[cells[i][0] - 1, cells[i][1] - 1] = 1; 
        }
        Queue<(int r, int c)> queue = new Queue<(int r, int c)>();
        for (int c = 0; c < col; c++) {
            if (grid[0, c] == 0) {
                queue.Enqueue((0, c));
                grid[0, c] = 1;
            }
        }
        int[] dr = {0, 0, 1, -1};
        int[] dc = {1, -1, 0, 0};
        while (queue.Count > 0) {
            (int r, int c) = queue.Dequeue();
            if (r == row - 1) return true;
            for (int i = 0; i < 4; i++) {
                int nr = r + dr[i];
                int nc = c + dc[i];
                if (nr >= 0 && nr < row && nc >= 0 && nc < col && grid[nr, nc] == 0) {
                    grid[nr, nc] = 1;
                    queue.Enqueue((nr, nc));
                }
            }
        }

        return false;
    }
}