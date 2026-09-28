public class Solution {
    public int MaxDepth(string s) {
        int result = 0, current = 0;
        foreach(char c in s){
            if(c == '('){
                current++;
                result = Math.Max(current, result);
            }
            else if(c == ')') current--;
        }
        return result;
    }
}