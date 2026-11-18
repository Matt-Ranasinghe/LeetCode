public class Solution {
    public int MinChanges(string s) {
        int result = 0;
        int n = s.Length;
        int count = 1;
        for(int i = 1; i < n; i++){
            if(s[i - 1] == s[i]) count++;
            else{
                if(count % 2 == 1) 
                {
                    result++;
                    count = 0;
                }
                else count = 1;
            }
        }
        return result;
    }
}