public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        int end = 0, result = 0;
        Array.Sort(intervals, (a, b) => {
            int firstComp = a[0].CompareTo(b[0]);
            if(firstComp != 0) return firstComp;
            return b[1].CompareTo(a[1]);
        });
        foreach(int[] range in intervals){
            if(end < range[1]){
                end = range[1];
                result++;
            }
        }
        return result;
    }
}