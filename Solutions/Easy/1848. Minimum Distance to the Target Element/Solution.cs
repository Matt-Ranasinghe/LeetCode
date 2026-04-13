public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int result = nums.Length - 1;
        for (int i = 0; i < nums.Length; i++) {
            result = nums[i] == target ?
                    (result > Math.Abs(i - start) ? Math.Abs(i - start) : result) :
                    result;
        }
        return result;
    }
}