public class Solution {
    public int[] MinBitwiseArray(IList<int> nums) {
        int n = nums.Count;
        int[] result = new int[n];
        for (int i = 0; i < n; i++) {
            int res = -1;
            int exp = 1;
            while ((nums[i] & exp) == 1) {
                res = nums[i] - exp;
                exp <<= 1;
            }
            result[i] = res;
        }
        return result;
    }
}