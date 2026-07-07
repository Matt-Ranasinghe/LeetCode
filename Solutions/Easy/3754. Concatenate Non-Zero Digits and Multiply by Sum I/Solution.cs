public class Solution {
    public long SumAndMultiply(int n) {
        long sum = 0, nonNeg = 0, pos = 1;
        while(n != 0){
            int val = n % 10;
            if(val != 0){
                nonNeg += pos * val;
                pos *= 10;
                sum += val;
            }
            n /= 10;
        }
        return sum * nonNeg;
    }
}