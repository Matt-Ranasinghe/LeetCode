public class Solution {
    public int MinimumOneBitOperations(int n) {
        int result = 0;
        
        while (n > 0) {
            int msb = MSB(n);
            result ^= FlipBits(msb);
            n ^= msb;
        }
        
        return result;
    }

    private int MSB(int n) {
        int msb = 1;
        while (msb <= n) {
            msb <<= 1;
        }
        return msb >> 1;
    }
    
    private int FlipBits(int msb) {
        return (msb << 1) - 1;
    }
}