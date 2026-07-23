public class Solution {
    public int UniqueXorTriplets(int[] nums) {
        int n = nums.Length;
        if(n < 3) return n;
        int pow = (int)Math.Ceiling(Math.Log(nums.Max() + 1, 2));
        return (int)Math.Pow(2, pow);
    }
}