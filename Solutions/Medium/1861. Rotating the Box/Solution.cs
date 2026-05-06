public class Solution {
    public char[][] RotateTheBox(char[][] boxGrid) {
        int n = boxGrid.Length, m = boxGrid[0].Length;
        char[][] result = new char[m][];
        for(int i = 0; i < m; i++){
            result[i] = new char[n];
            Array.Fill(result[i], '.');
        }
        for(int i = 0; i < n; i++){
            int pointer = m - 1;
            for(int j = m - 1; j >= 0; j--){
                if(boxGrid[i][j] == '#'){
                    result[pointer--][n - i - 1] = '#';
                }
                else if(boxGrid[i][j] == '*'){
                    result[j][n - i - 1] = '*';
                    pointer = j - 1;
                }
            }
        }
        return result;
    }
}