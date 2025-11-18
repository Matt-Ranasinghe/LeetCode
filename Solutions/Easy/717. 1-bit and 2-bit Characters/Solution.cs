public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int n = bits.Length;
        if(bits[n - 1] == 1) return false;
        for(int i = 0; i < n; i++){
            if(i == n - 1) return true;
            if(bits[i] == 1){
                i++;
            }
        }
        return false;
    }
}