public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        int mid = n / 2;
        return nums.Select(x => (int)Math.Abs(x - nums[mid])).Sum();
    }
}