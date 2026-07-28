public class Solution {
    public string SmallestPalindrome(string s) {
        int[] charCount = new int[26];
        foreach(char c in s){
            charCount[c - 'a']++;
        }
        char middle = '-';
        for(int i = 0; i < 26; i++){
            if(charCount[i] % 2 == 1){
                middle = (char)('a' + i);
                charCount[i]--;
                break;
            }
        }
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < 26; i++){
            int half = charCount[i]/2;
            char currentChar = (char)('a' + i);
            for(int j = 0; j < half; j++){
                sb.Append(currentChar);
            }
            charCount[i] -= half;
        }
        if(middle != '-') sb.Append(middle);
        for(int i = 25; i >= 0; i--){
            char currentChar = (char)('a' + i);
            for(int j = 0; j < charCount[i]; j++){
                sb.Append(currentChar);
            }
        }
        return sb.ToString();
    }
}