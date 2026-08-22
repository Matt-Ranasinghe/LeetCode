public class Solution {
    public bool CheckDivisibility(int n) {
        int mult = 1;
        int sum = 0;
        int copy = n;
        while(n != 0){
            int digit = n % 10;
            mult *= digit;
            sum += digit;
            n /= 10;
        }
        return copy % (mult + sum) == 0;
    }
}