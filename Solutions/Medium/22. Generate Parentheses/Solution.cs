public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        if(n == 1) return new List<string>(new string[] {"()"});
        List<string> prev = new List<string>();
        List<string> next = new List<string>();
        List<(int unpaired, int open)> openBrackets = new List<(int unpaired, int open)>();
        List<(int unpaired, int open)> newBrackets = new List<(int unpaired, int open)>();
        prev.Add("(");
        openBrackets.Add((1, 1));
        for(int i = 1; i < n * 2 - 1; i++){
            int m = prev.Count;
            for(int j = 0; j < m; j++){
                (int unpaired, int open) current = openBrackets[j];
                if(current.unpaired >= 1){
                    next.Add(prev[j] + ')');
                    newBrackets.Add((current.unpaired - 1, current.open));
                }
                if(current.open < n){
                    next.Add(prev[j] + '(');
                    newBrackets.Add((current.unpaired + 1, current.open + 1));
                }
            }
            prev = next;
            openBrackets = newBrackets;
            next = new List<string>();
            newBrackets = new List<(int unpaired, int open)>();
        }
        for(int i = 0; i < prev.Count; i++){
            prev[i] = prev[i] + ')';
        }
        return prev;
    }
}