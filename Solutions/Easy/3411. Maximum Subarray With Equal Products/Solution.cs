public class Solution {
    public int MaxLength(int[] nums) {
        int rs = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int gcd = nums[i];
            int lcm = nums[i];
            int mult = nums[i];
            if (mult == gcd * lcm) rs = Math.Max(rs, 1);
            for (int j = i + 1; j < nums.Length; j++)
            {
                int a = Math.Max(gcd, nums[j]);
                int b = Math.Min(gcd, nums[j]);
                gcd = CalculateGCD(a, b);
                a = Math.Max(lcm, nums[j]);
                b = Math.Min(lcm, nums[j]);
                lcm = CalculateLCM(a, b);
                mult *= nums[j];
                if (mult == gcd * lcm) rs = Math.Max(rs, j - i + 1);
            }
        }
        return rs;
    }
    private int CalculateLCM(int a, int b)
    {
        int gcd = CalculateGCD(a, b);
        return a * b / gcd;
    }
    private int CalculateGCD(int a, int b)
    {
        if (a % b == 0) return b;
        return CalculateGCD(b, a % b);
    }
}