public class Solution {
    public int MaxDistance(int[] colours) {
        int n = colours.Length;
        if(colours[0] != colours[n - 1]) return n - 1;
        int end = colours[n - 1], start = colours[0], dist = 0;
        for(int i = 1; i < n; i++){
            if(colours[i] != start) {
                dist = n - 1 - i;
                break;
            }
        }
        for(int i = n - 2; i >= 0; i--){
            if(colours[i] != end){
                return Math.Max(dist, i);
            }
        }
        return -1;
    }
}