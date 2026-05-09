public class Solution {
    public int[][] RotateGrid(int[][] grid, int k) {
        int n = grid.Length, m = grid[0].Length;
        List<int>[] rings = new List<int>[(int)Math.Min(n,m)/2];
        int top = 0, left = 0;
        int bottom = n - 1, right = m - 1;
        while (top < bottom && left < right) {
            rings[top] = new List<int>();
            for (int i = top; i < bottom; i++) {
                rings[top].Add(grid[i][left]);
            }
            for (int i = left; i < right; i++) {
                rings[top].Add(grid[bottom][i]);
            }
            for (int i = bottom; i > top; i--){
                rings[top].Add(grid[i][right]);
            }
            for (int i = right; i > left; i--) {
                rings[top].Add(grid[top][i]);
            }
            top++; left++; bottom--; right--;
        }
        top = 0;
        left = 0;
        bottom = n - 1;
        right = m - 1;
        int ringIndex = 0;
        while (top < bottom && left < right) {
            List<int> currentRing = rings[ringIndex++];
            int len = currentRing.Count;
            int offset = (len - (k % len)) % len;
            int p = 0; 
            for (int i = top; i < bottom; i++) {
                grid[i][left] = currentRing[(p++ + offset) % len];
            }
            for (int i = left; i < right; i++) {
                grid[bottom][i] = currentRing[(p++ + offset) % len];
            }
            for (int i = bottom; i > top; i--) {
                grid[i][right] = currentRing[(p++ + offset) % len];
            }
            for (int i = right; i > left; i--) {
                grid[top][i] = currentRing[(p++ + offset) % len];
            }
            top++; left++; bottom--; right--;
        }
        return grid;
    }
}