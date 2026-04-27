public class Solution {
    public int MirrorDistance(int n) {
        return Math.Abs(n - Reverse(n));
    }

    private int Reverse(int num){
        int result = 0;
        while(num > 0){
            result = (result * 10) + (num % 10);
            num /= 10;
        }
        return result;
    }
}