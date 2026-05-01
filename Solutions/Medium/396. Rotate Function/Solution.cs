public class Solution {
    public int MaxRotateFunction(int[] nums) {
        int n = nums.Length;
        int sum = 0;
        int R = 0;
        for (int i = 0; i < n; i++)
        {
            sum += nums[i];
            R += i * nums[i];
        }
        int res = R;
        for (int j = 1; j < n; j++)
        {
            R += sum - n * nums[n - j];
            res = Math.Max(res, R);
        }
        return res;
    }
}