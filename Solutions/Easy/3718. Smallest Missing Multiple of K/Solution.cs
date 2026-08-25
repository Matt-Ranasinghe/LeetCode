public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        Array.Sort(nums);
        int curr = k;
        foreach(int num in nums){
            if(num == curr) curr += k;
            else if(num > curr) return curr;
        }
        return curr;
    }
}