public class Solution {
    public bool CheckString(string s) {
        bool bSeen = false;
        foreach(char c in s){
            if(c == 'b') bSeen = true;
            else if(bSeen) return false;
        }
        return true;
    }
}