public class Solution {
    public bool HasAllCodes(string s, int k) {
        HashSet<string> seen = new HashSet<string>();
        int n = s.Length;
        int expectedCount = (int)Math.Pow(2,k);
        for(int i = 0; i < n - k + 1; i++){
            string substring = s[i..(k + i)];
            seen.Add(substring);
            if(expectedCount == seen.Count) return true;
        }
        return false;
    }
}