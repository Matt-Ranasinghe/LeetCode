public class Solution {
    public int TotalMoney(int n) {
        int div = n / 7;
        int mod = n % 7;
        int result = 28 * div + 7 * (div * (div - 1)) / 2;
        result += mod * (div + 1) + (mod * (mod - 1)) / 2;
        return result;
    }
}