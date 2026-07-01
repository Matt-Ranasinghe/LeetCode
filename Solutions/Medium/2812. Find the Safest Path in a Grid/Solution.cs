public class Solution {
    public int MaximumSafenessFactor(IList<IList<int>> grid) {
        int n = grid.Count, m = grid[0].Count;
        if(grid[0][0] == 1 || grid[n - 1][m - 1] == 1) return 0;
        Queue<(int x, int y)> queue = new Queue<(int x, int y)>();
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(grid[i][j] == 1) {
                    grid[i][j] = -1;
                    queue.Enqueue((i, j));
                }
            }
        }
        int[][] directions = new int[4][]{
            new int[2] {0, 1},
            new int[2] {1, 0},
            new int[2] {0, -1},
            new int[2] {-1, 0}
        };
        int size = queue.Count, count = 0;
        int level = 1;
        while(queue.Count > 0){
            if(count == size){
                level++;
                count = 0;
                size = queue.Count;
            }
            count++;
            (int x, int y) cell = queue.Dequeue();
            foreach(int[] direction in directions){
                int cx = cell.x + direction[0];
                int cy = cell.y + direction[1];
                if(cx >= 0 && cx < n && cy >= 0 && cy < m && grid[cx][cy] == 0){
                    grid[cx][cy] = level;
                    queue.Enqueue((cx, cy));
                }
            }
        }
        int x = 0, y = 0;
        int result = grid[0][0];
        PriorityQueue<(int x, int y), int> pq = new PriorityQueue<(int x, int y), int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        HashSet<(int x, int y)> seen = new HashSet<(int x, int y)>();
        pq.Enqueue((x, y), grid[0][0]);
        seen.Add((x, y));
        while(x < n - 1 || y < m - 1){
            (int x, int y) cell = pq.Dequeue();
            x = cell.x;
            y = cell.y;
            result = Math.Min(grid[x][y], result);
            foreach(int[] direction in directions){
                int cx = cell.x + direction[0];
                int cy = cell.y + direction[1];
                if(cx >= 0 && cx < n && cy >= 0 && cy < m && !seen.Contains((cx, cy))){
                    pq.Enqueue((cx, cy), grid[cx][cy]);
                    seen.Add((cx, cy));
                }
            }
        }
        return result == -1 ? 0 : result;
    }
}