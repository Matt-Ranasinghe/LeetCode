// See https://aka.ms/new-console-template for more information
public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        int n = nums.Count;
        if(n < 2 * k) return false;
        bool[] increasing = new bool[n];
        int length = 0, prev = -1001;
        for(int i = 0; i < n; i++){
            if(prev < nums[i]){
                length++;
            }
            else {
                length = 1;
            }
            if(length >= k){
                increasing[i] = true;
                if(i >= k && increasing[i - k]) return true;
            }
            prev = nums[i];
        }
        return false;
    }
}