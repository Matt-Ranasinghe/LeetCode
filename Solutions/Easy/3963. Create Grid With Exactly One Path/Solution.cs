public class Solution {
    public string[] CreateGrid(int m, int n) {
        string[] result = new string[m];
        result[0] = new string('.', n);
        string downwards = new string('#', n - 1) + '.';
        for(int i = 1; i < m; i++){
            result[i] = downwards;
        }
        return result;
    }
}