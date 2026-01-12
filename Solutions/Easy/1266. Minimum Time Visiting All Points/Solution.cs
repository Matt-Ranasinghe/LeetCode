public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int prev_x = points[0][0], prev_y = points[0][1];
        int res = 0;
        for(int i = 1; i < points.Length; i++)
        {
            res += Math.Max(Math.Abs(prev_x - points[i][0]), Math.Abs(prev_y - points[i][1]));
            prev_x = points[i][0];
            prev_y = points[i][1];
        }
        return res;
    }
}