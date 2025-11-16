public class Solution {
    public int NumSub(string s) {
        const int MOD = (int) 1e9 + 7; 
        int run = 0, result = 0;
        foreach(int c in s){
            if(c == '1') {
                run++;
                result = (run + result) % MOD;
            }
            else run = 0;
        }
        return result;
    }
}