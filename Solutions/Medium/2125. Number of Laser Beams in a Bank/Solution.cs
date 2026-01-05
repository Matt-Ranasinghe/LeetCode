public class Solution {
    public int NumberOfBeams(string[] bank) {
        int prev = 0, result = 0;
        foreach(string row in bank){
            int count = 0;
            foreach(char c in row){
                if(c == '1') count++;
            }
            if(count != 0) {
                result += prev * count;
                prev = count;
            }
        }
        return result;
    }
}