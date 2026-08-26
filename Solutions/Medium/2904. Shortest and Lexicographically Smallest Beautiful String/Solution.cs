public class Solution {
    public string ShortestBeautifulSubstring(string s, int k) {
        int n = s.Length;
        List<int> onePos = new List<int>();
        for(int i = 0; i < n; i++){
            if(s[i] == '1') onePos.Add(i);
        }
        if(onePos.Count < k) return "";
        int minLength = 0;
        int kLength = k - 1;
        List<int> candidates = new List<int>();
        for(int i = 0; i < onePos.Count - kLength; i++){
            int newLength = onePos[i + kLength] - onePos[i];
            if(newLength < minLength || candidates.Count == 0){
                candidates.Clear();
                candidates.Add(onePos[i]);
                minLength = newLength;
                if(minLength == kLength) return s.Substring(onePos[i], k);
            }
            else if(newLength == minLength){
                candidates.Add(onePos[i]);
            }
        }
        string result = s.Substring(candidates[0], minLength + 1);
        for(int i = 1; i < candidates.Count; i++){
            string newSubstring = s.Substring(candidates[i], minLength + 1);
            result = result.CompareTo(newSubstring) < 0 ? result : newSubstring;
        }
        return result;
    }
}