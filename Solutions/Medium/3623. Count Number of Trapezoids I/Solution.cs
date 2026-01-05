public class Solution {
    public int CountTrapezoids(int[][] points) {
        const int MOD = (int) 1e9 + 7;
        Dictionary<long, (long total, int add)> levels = new Dictionary<long, (long total, int add)>();
        foreach(int[] point in points){
            if(!levels.ContainsKey(point[1])) levels[point[1]] = (0, 1);
            else {
                (long total, int add) tuple = levels[point[1]];
                levels[point[1]] = (tuple.total + tuple.add, tuple.add + 1);
            }
        }
        long result = 0;
        long prefix = 0;
        foreach((long total, int add) level in levels.Values){
            result = ((result + prefix * level.total) % MOD);
            prefix += level.total;
        }
        return (int) result;
    }
}