public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int pointer = -k - 1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 1){
                if(pointer + k >= i) return false;
                pointer = i;
            }
        }
        return true;
    }
}