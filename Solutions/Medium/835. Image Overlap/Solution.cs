public class Solution {
    public int LargestOverlap(int[][] img1, int[][] img2) {
        int n = img1.Length;
        int totOne = 0;
        foreach(int[] row in img2){
            foreach(int num in row){
                totOne += num;
            }
        }
        if(totOne == 0) return 0;
        int[,] copies = new int[n * 2, n * 2];
        int result = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(img1[i][j] == 1){
                    result = Math.Max(MaxMatches(n, img1, img2, i, j, copies), result);
                }
            }
        }
        return result;
    }

    private int MaxMatches(int n, int[][] img1, int[][] img2, int x, int y, int[,] copies){
        int result = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(img2[i][j] == 1){
                    int cx = i - x;
                    int cy = j - y;
                    copies[cx + n,cy + n]++;
                    result = Math.Max(copies[cx + n, cy + n], result);
                }
            }
        }
        return result;
    }
}