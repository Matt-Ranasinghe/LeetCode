public class Solution {
    public int NumberOfSubstrings(string s) {
        int n = s.Length;
        int[] chars = new int[3];
        int leftPointer = 0, rightPointer = 0;
        int result = 0;
        foreach(char c in s){
            rightPointer++;
            chars[c - 'a']++;
            bool minChar = true;;
            foreach(int i in chars){
                if(i == 0) {
                    minChar = false;
                    break;
                }
            }
            while(minChar){
                result += n - rightPointer + 1;
                if(--chars[s[leftPointer++] - 'a'] == 0) break;
            }
        }
        return result;
    }
}