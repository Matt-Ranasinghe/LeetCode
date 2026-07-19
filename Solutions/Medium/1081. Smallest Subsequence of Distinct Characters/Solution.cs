public class Solution {
    public string SmallestSubsequence(string s) {
        
        int[] last = new int[26];
        for (int i = 0; i < s.Length; i++) last[s[i] - 'a'] = i;
        
        var stack = new Stack<char>();
        var seen = new HashSet<char>();

        for (int i = 0; i < s.Length; i++){
             char c = s[i];

            if (seen.Contains(c))
                continue;

            while(stack.Count>0 && stack.Peek() > c && last[stack.Peek() -'a'] > i){
                seen.Remove(stack.Pop());
            }
            stack.Push(c);
            seen.Add(c);
        }
        return new string(stack.Reverse().ToArray());
    }
}