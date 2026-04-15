public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        int n = words.Length;
        for(int i = 0; i <= n / 2; i++){
            if(words[(startIndex - i + n) % n] == target) return i;
            if(words[(startIndex + i) % n] == target) return i;
        }
        return -1;
    }
}