public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int n = nums1.Length, m = nums2.Length;
        int pointer1 = 0, pointer2 = 0;
        while(pointer1 < n && pointer2 < m){
            int num1 = nums1[pointer1];
            int num2 = nums2[pointer2];
            if(num1 == num2) return num1;
            else if(num1 > num2) pointer2++;
            else pointer1++;
        }
        return -1;
    }
}