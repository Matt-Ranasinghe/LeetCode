public class Solution {
    public int[] PathsWithMaxScore(IList<string> board) {
        int n = board.Count, m = board[0].Length;
        int MOD = 1_000_000_007;
        int[,] dpValue = new int[n, m];
        int[,] dpRoutes = new int[n, m];
        dpValue[n - 1, m - 1] = 0;
        dpRoutes[n - 1, m - 1] = 1;
        int[][] directions = new int[3][]{
            new int[] {-1, 0},
            new int[] {0, -1},
            new int[] {-1, -1}
        };
        PriorityQueue<(int x, int y), (int x, int y)> pq = new PriorityQueue<(int x, int y), (int x, int y)>(
            Comparer<(int x, int y)>.Create((a, b) => (b.x + b.y).CompareTo(a.x + a.y))
        );
        pq.Enqueue((n - 1, m - 1), (n - 1, m - 1));
        bool[,] queued = new bool[n, m];
        queued[n - 1, m - 1] = true;
        while (pq.Count > 0) {
            (int x, int y) cell = pq.Dequeue();
            int val = dpValue[cell.x, cell.y];
            int routes = dpRoutes[cell.x, cell.y];
            if (routes == 0) continue; 
            foreach (int[] direction in directions) {
                int cx = cell.x + direction[0], cy = cell.y + direction[1];
                if (cx < 0 || cy < 0 || board[cx][cy] == 'X') continue;
                int cellValue = board[cx][cy] == 'E' ? 0 : (board[cx][cy] - '0');
                int newVal = cellValue + val;
                if (dpValue[cx, cy] < newVal) {
                    dpValue[cx, cy] = newVal;
                    dpRoutes[cx, cy] = routes;
                    if (!queued[cx, cy]) {
                        pq.Enqueue((cx, cy), (cx, cy));
                        queued[cx, cy] = true;
                    }
                }
                else if (dpValue[cx, cy] == newVal) {
                    dpRoutes[cx, cy] = (dpRoutes[cx, cy] + routes) % MOD;
                }
            }
        }
        return new int[2] { dpValue[0, 0], dpRoutes[0, 0] };
    }
}