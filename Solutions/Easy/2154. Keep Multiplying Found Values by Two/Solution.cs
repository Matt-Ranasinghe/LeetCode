public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        HashSet<int> seen = new HashSet<int>();
        foreach(int num in nums){
            if(num > original) seen.Add(num);
            else if(num == original){
                do{
                    original *= 2;
                }while(seen.Contains(original));
            }
        }
        return original;
    }
}