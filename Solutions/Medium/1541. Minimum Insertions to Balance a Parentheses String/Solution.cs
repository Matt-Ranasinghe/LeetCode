public class Solution {
    public int MinInsertions(string s) {
        int result = 0;
        int left = 0;
        int n = s.Length;
        for(int i = 0; i < n; i++){
            if(s[i] == '(') left++;
            else{
                if(left > 0) left--;
                else result++;
                if(i >= n - 1 || s[i + 1] != ')') result++;
                else i++; 
            }
        }
        return result + left * 2;
    }
}