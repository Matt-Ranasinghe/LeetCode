public class Solution {
    public bool UniformArray(int[] nums1) {
        int min = nums1[0];
        bool hasOdd = false;
        foreach (int num in nums1) {
            if (num < min) {
                min = num;
            }
            if ((num & 1) == 1) {
                hasOdd = true;
            }
        }
        if ((min & 1) == 1) {
            return true;
        }
        return !hasOdd;
    }
}