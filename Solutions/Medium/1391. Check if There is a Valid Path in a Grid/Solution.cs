public class Solution {
    public bool HasValidPath(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        if (m == 1 && n == 1) return true;
        var queue = new Queue<(int r, int c)>();
        var seen = new HashSet<(int r, int c)>();
        queue.Enqueue((0, 0));
        seen.Add((0, 0));
        var move = new Dictionary<char, (int dr, int dc)> {
            {'L', (0, -1)}, {'R', (0, 1)}, {'U', (-1, 0)}, {'D', (1, 0)}
        };
        var pipeConnections = new char[][] {
            new char[] {'L', 'R'},
            new char[] {'U', 'D'},
            new char[] {'L', 'D'},
            new char[] {'R', 'D'},
            new char[] {'L', 'U'},
            new char[] {'R', 'U'}
        };
        var opposites = new Dictionary<char, char> {
            {'L', 'R'}, {'R', 'L'}, {'U', 'D'}, {'D', 'U'}
        };
        while (queue.Count > 0) {
            var (r, c) = queue.Dequeue();
            int pipeType = grid[r][c] - 1;
            foreach (char dir in pipeConnections[pipeType]) {
                int nr = r + move[dir].dr;
                int nc = c + move[dir].dc;
                if (nr >= 0 && nr < m && nc >= 0 && nc < n && !seen.Contains((nr, nc))) {
                    int nextPipeType = grid[nr][nc] - 1;
                    char requiredConnection = opposites[dir];
                    if (pipeConnections[nextPipeType].Contains(requiredConnection)) {
                        if (nr == m - 1 && nc == n - 1) return true;
                        seen.Add((nr, nc));
                        queue.Enqueue((nr, nc));
                    }
                }
            }
        }
        return false;
    }
}