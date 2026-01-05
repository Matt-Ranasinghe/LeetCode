public class Solution {
    public int MaxOperations(string s) {
        bool oneSeen = false;
        int ones = 0, result = 0;
        foreach(char c in s){
            if(c == '1') {
                oneSeen = true;
                ones++;
            }
            else if(oneSeen) {
                oneSeen = false;
                result += ones;
            }
        }
        return result;
    }
}