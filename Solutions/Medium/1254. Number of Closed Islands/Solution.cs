public class Solution {
    private static int[][] directions = new int[4][]{ new int[] {1, 0}, new int[] {0, 1}, new int[] {-1, 0}, new int[] {0, -1}};
    public int ClosedIsland(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        HashSet<(int y, int x)> seen = new HashSet<(int y, int x)>();
        int res = 0;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if(grid[i][j] == 0 && !seen.Contains((i, j)))
                {
                    res += BFS(n, m, grid, (i, j), seen);
                }
            }
        }
        return res;
    }
    private int BFS(int n, int m, int[][] grid, (int y, int x) startPos, HashSet<(int y, int x)> seen)
    {
        Queue<(int y, int x)> q = new Queue<(int y, int x)>();
        q.Enqueue(startPos);
        seen.Add(startPos);
        bool enclosed = true;
        while(q.Count > 0)
        {
            var curLoc = q.Dequeue();
            for(int i = 0; i < 4; i++)
            {
                (int y, int x) nextLoc = (curLoc.y + directions[i][0], curLoc.x + directions[i][1]);
                if(InBounds(n, m, nextLoc.y, nextLoc.x))
                {
                    if(!seen.Contains(nextLoc) && grid[nextLoc.y][nextLoc.x] == 0)
                    {
                        seen.Add(nextLoc);
                        q.Enqueue(nextLoc);
                    }
                }
                else
                {
                    enclosed = false;
                }
            }
        }
        return enclosed ? 1 : 0;
    }
    private bool InBounds(int n, int m, int y, int x)
    {
        return (y < 0 || y >= n || x < 0 || x >= m) ? false : true;
    }
}