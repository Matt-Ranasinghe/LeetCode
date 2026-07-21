public class Solution {
    public int MaxActiveSectionsAfterTrade(string s) {
        int n = s.Length;
        int ones = 0;
        foreach(char c in s){
            if(c == '1') ones++;
        }
        int current = 0;
        int prev = Int32.MinValue;
        int bestActivation = 0;
        char cur = '1';
        for(int i = 0; i < n; i++){
            if(cur != s[i]){
                if(cur == '0') {
                    bestActivation = Math.Max(prev + current, bestActivation);
                    prev = current;
                    current = 0;
                }
                cur = s[i];
            }
            if(cur == '0'){
                current++;
            }
        }
        if(cur == '0') bestActivation = Math.Max(prev + current, bestActivation);
        return ones + bestActivation;
    }
}