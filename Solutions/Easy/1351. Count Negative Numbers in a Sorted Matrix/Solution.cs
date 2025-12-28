public class Solution {
    public int CountNegatives(int[][] grid) {
        int n = grid[0].Length, result = 0;
        foreach(int[] row in grid){
            result += BinarySearch(row, n);
        }
        return result;
    }

    private int BinarySearch(int[] row, int n){
        int left = 0, right = n - 1, res = -1;
        while(left <= right){
            int mid = left + (right - left) / 2;
            if (row[mid] >= 0){
                left = mid + 1;
            }
            else{
                right = mid - 1;
                res = mid;
            }
        }
        return res == -1 ? 0 : n - res;
    }
}