 public class Solution {

    public int NumDistinct(string s, string t) {
        int n = s.Length, m = t.Length;
        int[,] paths = new int[n,m];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                paths[i, j] = -1;
            }
        }
        return numOfPaths(paths, 0, 0, s, t);
    }


    private int numOfPaths(int[,] paths, int tPos, int sPos, string s, string t){
        if(tPos == t.Length) return 1;
        if(sPos == s.Length) return 0;
        if(paths[sPos,tPos] != -1) return paths[sPos,tPos];
        if(s[sPos] == t[tPos]) {
            paths[sPos,tPos] = numOfPaths(paths, tPos + 1, sPos + 1, s, t) + numOfPaths(paths, tPos, sPos + 1, s, t);
            return paths[sPos,tPos];
        }
        paths[sPos,tPos] = numOfPaths(paths, tPos, sPos + 1, s, t);
        return paths[sPos,tPos];
    }
} 