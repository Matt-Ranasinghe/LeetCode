public class Solution {
    public int SmallestNumber(int n) {
        int result = 1;
        while(result < n){
            result *= 2;
            result++;
        }
        return result;
    }
}