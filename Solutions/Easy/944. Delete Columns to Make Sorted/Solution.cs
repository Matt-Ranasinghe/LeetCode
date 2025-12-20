public class Solution {
    public int MinDeletionSize(string[] strs) {
        int n = strs.Length, m = strs[0].Length, result = 0;
        for(int i = 0; i < m; i++){
            char prev = '0';
            for(int j = 0; j < n; j++){
                if(prev.CompareTo(strs[j][i]) > 0){
                    result++;
                    break;
                }
                prev = strs[j][i];
            }
        }
        return result;
    }
}