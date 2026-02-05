public class Solution {
    public int[] ConstructTransformedArray(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        for(int i = 0; i < n; i++){
            int move = i + nums[i];
            if(move < 0) move = move % n + n;
            result[i] = nums[move % n];
        }
        return result;
    }
}