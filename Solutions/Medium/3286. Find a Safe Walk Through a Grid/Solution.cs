public class Solution {
    public bool FindSafeWalk(IList<IList<int>> grid, int health) {
        int n = grid.Count, m = grid[0].Count;
        if(health - grid[0][0] == 0) return false;
        if(n == 1 && m == 1 && health - grid[0][0] > 0) return true;
        PriorityQueue<(int x, int y, int health), int> pq = new PriorityQueue<(int x, int y, int health), int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
        pq.Enqueue((0,0,health - grid[0][0]),health - grid[0][0]);
        grid[0][0] = -1;
        int[][] directions = new int[4][]{
            new int[2] {0, 1},
            new int[2] {1, 0},
            new int[2] {0, -1},
            new int[2] {-1, 0}
        };
        while(pq.Count > 0){
            (int x, int y, int health) cell = pq.Dequeue();
            int x = cell.x;
            int y = cell.y;
            int cellHealth = cell.health;
            foreach(int[] direction in directions){
                int cx = x + direction[0];
                int cy = y + direction[1];
                if(cx >= 0 && cx < n && cy >= 0 && cy < m && grid[cx][cy] != -1){
                    if(cx == n - 1 && cy == m - 1 && cellHealth - grid[cx][cy] > 0) return true; 
                    pq.Enqueue((cx, cy, cellHealth - grid[cx][cy]), cellHealth - grid[cx][cy]);
                    grid[cx][cy] = -1;
                }
            }
        }
        return false;
    }
}