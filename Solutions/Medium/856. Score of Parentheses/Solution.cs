public class Solution {
    public int ScoreOfParentheses(string s) {
        int result = 0, n = s.Length;
        int openBrackets = 0;
        for(int i = 0; i < n; i++){
            if(s[i] == '(') {
                openBrackets++;
            }
            else if(s[i - 1] == '('){
                result += 1 << --openBrackets;
            }
            else openBrackets--;
        }
        return result;
    }
}