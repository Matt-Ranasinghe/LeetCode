public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        int n = nums1.Length, m = nums2.Length, result = 0;
        int highestPrev = 0, right = 0;
        for(int i = 0; i < n; i++){
            if(right == m) return result;
            while(right < m && nums2[right] >= nums1[i]) right++;
            result = Math.Max(result, right - i - 1);
        }
        return result;
    }
}