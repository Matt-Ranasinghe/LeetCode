public class Solution {
    public int CountOdds(int low, int high) {
        return low % 2 == 1 ? (int)Math.Floor((double)(high - low)/2) + 1 : (int)Math.Ceiling((double)(high - low)/2);
    }
}