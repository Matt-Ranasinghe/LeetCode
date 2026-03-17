public class Solution {
    public int[] GetBiggestThree(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        int[,,] prefixDiag = new int[n,m,2];
        List<int> scores = new List<int>();
        for (int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(i == 0 || j == 0){
                    prefixDiag[i,j,0] = grid[i][j];
                }
                else{
                    prefixDiag[i,j,0] = grid[i][j] + prefixDiag[i-1,j-1,0];
                }
                if(i == 0 || j == m - 1){
                    prefixDiag[i,j,1] = grid[i][j];
                }
                else{
                    prefixDiag[i,j,1] = grid[i][j] + prefixDiag[i-1,j+1,1];
                }
                scores.Add(grid[i][j]);
            }
        }
        for(int side = 1; side < Math.Min(n,m); side++){
            for(int i = side; i < n - side; i++){
                for(int j = side; j < m - side; j++){
                    scores.Add(CalculateDiamondScore(prefixDiag, i, j, side, grid));
                }
            }
        }
        scores.Sort((x,y) => y.CompareTo(x));
        List<int> results = new List<int>();
        for(int i = 0; i < scores.Count; i++) 
        {
            if(results.Contains(scores[i])) continue;
            else{
                results.Add(scores[i]);
            }
            if(results.Count == 3) break;
        }
        return results.ToArray();
    }

    private int GetPrefixVal(int[,,] prefixDiag, int r, int c, int type) {
        int n = prefixDiag.GetLength(0);
        int m = prefixDiag.GetLength(1); // Get column count
        if (r < 0 || r >= n || c < 0 || c >= m) return 0; // Use m here
        return prefixDiag[r, c, type];
    }
    private int CalculateDiamondScore(int[,,] prefixDiag, int i, int j, int side, int[][] grid) {
    int edge1 = GetPrefixVal(prefixDiag, i + side, j, 0) - GetPrefixVal(prefixDiag, i - 1, j - side - 1, 0);
    int edge2 = GetPrefixVal(prefixDiag, i, j + side, 0) - GetPrefixVal(prefixDiag, i - side - 1, j - 1, 0);
    int edge3 = GetPrefixVal(prefixDiag, i, j - side, 1) - GetPrefixVal(prefixDiag, i - side - 1, j + 1, 1);
    int edge4 = GetPrefixVal(prefixDiag, i + side, j, 1) - GetPrefixVal(prefixDiag, i - 1, j + side + 1, 1);
    int duplicatedCorners = grid[i][j-side] + grid[i][j+side] + grid[i-side][j] + grid[i+side][j];
    return edge1 + edge2 + edge3 + edge4 - duplicatedCorners;
    }
}