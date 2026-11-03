public class Solution {
    public int MinMoves(int[] nums) => nums.Max() * nums.Length - nums.Sum();
}