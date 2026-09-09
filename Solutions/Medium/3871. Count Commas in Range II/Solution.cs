public class Solution {
    public long CountCommas(long n) {
        if(n < 1000) return 0;
        long maxCommas = 0;
        long UB = 999999, LB = 999, count = 1;
        long result = 0;
        while(UB < n){
            result += (UB - LB) * count;
            count++;
            LB = UB;
            UB = UB * 1000 + 999;
        }
        result += (n - LB) * count;
        return result;
    }
}
