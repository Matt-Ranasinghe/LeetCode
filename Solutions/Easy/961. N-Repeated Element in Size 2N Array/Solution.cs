public class Solution {
    public int RepeatedNTimes(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        foreach(int num in nums){
            if(!seen.Contains(num)) seen.Add(num);
            else return num;
        }
        return -1;
    }
}