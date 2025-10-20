public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int res = 0;
        foreach(string s in operations){
            if (s.Contains('+')) res++;
            else res--;
        }
        return res;
    }
}