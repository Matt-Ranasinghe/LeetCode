public class Solution {
    public bool CheckOnesSegment(string s) {
        bool oneSeen = false, halted = false;
        foreach(char c in s){
            if(c == '1') 
            {
                oneSeen = true;
                if(halted) return false;
            }
            else if(oneSeen) halted = true;
        }
        return true;
    }
}