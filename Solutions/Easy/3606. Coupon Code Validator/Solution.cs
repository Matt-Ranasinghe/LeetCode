public class Solution {
    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive) {
        HashSet<char> letters = new HashSet<char>();
        HashSet<string> business = new HashSet<string>(){"electronics", "grocery", "pharmacy", "restaurant"};
        for(int i = (int)'A'; i <= (int)'Z'; i++){
            letters.Add((char)i);
        }
        for(int i = (int) 'a'; i <= (int)'z'; i++){
            letters.Add((char)i);
        }
        for(int i = 0; i <= 9; i++){
            letters.Add((char)(i + '0'));
        }
        letters.Add('_');
        Dictionary<string, List<string>> resultBuilder = new Dictionary<string, List<string>>();
        int n = code.Length;
        foreach(string b in business){
            resultBuilder[b] = new List<string>();
        }
        for(int i = 0; i < n; i++){
            bool valid = true;
            if(code[i].Length < 1) continue;
            foreach(char c in code[i]){
                if(!letters.Contains(c)){
                    valid = false;
                    break;
                }
            }
            if(valid && business.Contains(businessLine[i]) && isActive[i]){
                resultBuilder[businessLine[i]].Add(code[i]);
            }
        }
        IList<string> result = new List<string>();
        foreach(List<string> businesses in resultBuilder.Values){
            businesses.Sort(StringComparer.Ordinal);
            foreach(string b in businesses){
                result.Add(b);
            }
        }
        return result;
    }
}