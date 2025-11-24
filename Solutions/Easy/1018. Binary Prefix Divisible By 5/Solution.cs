public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        List<bool> result = new List<bool>();
        int bTen = 0;
        foreach(int num in nums){
            bTen <<= 1;
            bTen += num;
            bTen %= 5;
            result.Add((bTen == 0));
        }
        return result;
    }
}