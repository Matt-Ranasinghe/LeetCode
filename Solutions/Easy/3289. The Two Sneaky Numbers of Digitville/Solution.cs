public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        bool[] seen = new bool[101];
        List<int> result = new List<int>();
        foreach(int num in nums){
            if(seen[num]) result.Add(num);
            else seen[num] = true;
        }
        return result.ToArray();
    }
}