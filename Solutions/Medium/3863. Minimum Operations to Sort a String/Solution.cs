public class Solution {
    public int MinOperations(string s) {
        int n = s.Length;
        if(n == 1) return 0;
        char[] p = s.ToCharArray();
        Array.Sort(p);
        string sorted = new string(p);
        if(sorted == s) return 0;
        if(n == 2) return -1;
        char charMin = 'z', charMax = 'a';
        int minCount = 0, maxCount = 0;
        foreach(char c in s){
            if(charMin == c) minCount++;
            else if(charMin > c) {
                charMin = c;
                minCount = 1;
            }
            if(charMax == c) maxCount++;
            else if(charMax < c) {
                charMax = c;
                maxCount = 1;
            }
        }
        if(charMax == s[0] && maxCount == 1 && charMin == s[n - 1] && minCount == 1) return 3;
        if(charMax == s[n - 1] || charMin == s[0]) return 1;
        else return 2;
    }
}