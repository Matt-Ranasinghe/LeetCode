public class Solution {
    public bool CheckValidString(string s) {
        int leftMin = 0;
        int leftMax = 0;
        foreach(char c in s)
        {
            if(c == '(')
            {
                leftMin++;
                leftMax++;
            }
            if(c == ')')
            {
                leftMin--;
                leftMax--;
            }
            if(c == '*')
            {
                leftMin--;
                leftMax++;
            }
            if(leftMin < 0) leftMin = 0;
            if(leftMax < 0) return false;
        }
        if(leftMin == 0) return true;
        return false;
    }
}