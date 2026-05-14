public class Solution {
    public bool IsGood(int[] nums) {
        int n = nums.Length;
        int[] seen = new int[n];
        foreach(int num in nums){

            if(num >= n) return false;
            if(num == n - 1){
                if(seen[num] > 1) return false;
            }
            else if(seen[num] > 0) return false;
            seen[num]++;
        }
        for(int i = 1; i < n; i++){
            if(seen[i] == 0) return false;
        }
        return true;
    }
}