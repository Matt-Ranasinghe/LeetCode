public class Solution {
    public int LargestAltitude(int[] gain) {
        int max = 0, current = 0;
        foreach(int num in gain){
            current += num;
            max = Math.Max(max, current);
        }
        return max;
    }
}