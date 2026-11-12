public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int result = 1;
        int len = 1;
        char direction = 'i';
        for(int i = 1;i < nums.Length; i++){
            if(nums[i - 1] < nums[i]){
                if(direction != 'i'){
                    len = 1;
                    direction = 'i';
                }
                len++;
                result = Math.Max(result,len);
            }
            else if(nums[i - 1] > nums[i]){
                if(direction != 'd'){
                    len = 1;
                    direction = 'd';
                }
                len++;
                result = Math.Max(result,len);
            }
            else{
                len = 1;
            }
        }
        return result;
    }
}