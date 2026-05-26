public class Solution {
    public int NumberOfSpecialChars(string word) {
        bool[] upperCase = new bool[26];
        bool[] lowerCase = new bool[26];
        foreach(char c in word){
            if(c < 'Z' + 1){
                upperCase[c - 'A'] = true;
            }
            else lowerCase[c - 'a'] = true;
        }
        int result = 0;
        for(int i = 0; i < 26; i++){
            result += upperCase[i] && lowerCase[i] ? 1 : 0;
        }
        return result;
    }
}