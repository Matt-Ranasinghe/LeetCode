public class Solution {
    public string Evaluate(string s, IList<IList<string>> knowledge) {
        int n = s.Length;
        Dictionary<string, string> knowledgeDict = new Dictionary<string, string>();
        foreach(List<string> pair in knowledge){
            knowledgeDict[pair[0]] = pair[1];
        }
        string result = "";
        for(int i = 0; i < n; i++){
            if(s[i] == '('){
                string key = "";
                i++;
                while(s[i] != ')'){
                    key = key + s[i];
                    i++;
                }
                if(knowledgeDict.ContainsKey(key)){
                    result = result + knowledgeDict[key];
                }
                else result = result + '?';
            }
            else result = result + s[i];
        }
        return result;
    }
}