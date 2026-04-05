public class Solution {
    public bool JudgeCircle(string moves) {
        int up = 0, down = 0, left = 0, right = 0;
        foreach(char c in moves){
            if(c == 'U') up++;
            else if(c == 'D') down++;
            else if(c == 'L') left++;
            else right++;
        }
        return up == down && left == right;
    }
}