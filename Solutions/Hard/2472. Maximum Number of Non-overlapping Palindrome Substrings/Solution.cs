public class Solution {
    public int MaxPalindromes(string s, int k) {
        int n = s.Length;
        int result = 0;
        int minDist = (k - 1)/ 2;
        for(int i = minDist; i < n - (k / 2); i++){
            int left = i, right = i;
            bool evenFound = false, oddFound = false;
            if(k % 2 == 0){
                evenFound = EvenPalindrome(s, i, k);
                if(!evenFound) oddFound = OddPalindrome(s, i + 1, k);
                if(evenFound) 
                {
                    i = i + k - 1;
                    result++;
                }
                else if(oddFound) {
                    i = i + k;
                    result++;
                }
            }
            else{
                oddFound = OddPalindrome(s, i, k);
                if(!oddFound) evenFound = EvenPalindrome(s, i, k);
                if(oddFound) 
                {
                    i = i + k - 1;
                    result++;
                }
                else if(evenFound) {
                    i = i + k;
                    result++;
                }
            }
        }
        return result;
    }

    private bool EvenPalindrome(string s, int i, int k){
        int left = i, right = i + 1;
        while(right < s.Length && s[left] == s[right]){
            if(right - left + 1 >= k) return true;
            left--;
            right++;
        }
        return false;
    }

    private bool OddPalindrome(string s, int i, int k){
        int left = i, right = i;
        while(right < s.Length && s[left] == s[right]){
            if(right - left + 1 >= k) return true;
            left--;
            right++;
        }
        return false;
    }
}