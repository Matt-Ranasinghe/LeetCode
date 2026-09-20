public class Solution {
    public int ReverseDegree(string s) {
        int result = 0, n = s.Length;
        for(int i = 0; i < n; i++){
            result += ('z' - s[i] + 1) * (i + 1);
        }
        return result;
    }
}