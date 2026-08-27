public class Solution {
    public string LexGreaterPermutation(string s, string target) {
        int[] charCounts = new int[26];
        foreach(char c in s) charCounts[c - 'a']++;
        Stack<char> stack = new Stack<char>();
        foreach(char c in target){
            if(charCounts[c - 'a'] > 0){
                stack.Push(c);
                charCounts[c - 'a']--;
            }
            else{
                return FindOptimalChar(stack, c, charCounts);
            }
        }
        int n = target.Length;
        char[] result = new char[n];
        int[] available = new int[26];
        bool madeSwap = false;
        for(int i = n - 1; i >= 0; i--){
            result[i] = target[i];
            if(!madeSwap){
                int charVal = target[i] - 'a';
                for(int j = charVal + 1; j < 26; j++){
                    if(available[j] > 0){
                        madeSwap = true;
                        result[i] = target[available[j]];
                        result[available[j]] = target[i];
                        Array.Sort(result, i + 1, n - i - 1);
                        break;
                    }
                }
                available[charVal] = i;
            }
        }
        return madeSwap ? new string(result) : "";
    }

    private string FindOptimalChar(Stack<char> stack, char c, int[] charCounts){
        for(int i = (c - 'a' + 1); i < 26; i++){
            if(charCounts[i] > 0){
                stack.Push((char)(i + 'a'));
                charCounts[i]--;
                stack = AddRemainingChars(charCounts, stack);
                return ConvToString(stack);
            }
        }
        if(stack.Count == 0) return "";
        else{
            char popped = stack.Pop();
            charCounts[popped - 'a']++;
            string res = FindOptimalChar(stack, popped, charCounts);
            return res;
        }
    }

    private Stack<char> AddRemainingChars(int[] charCounts, Stack<char> stack){
        for(int i = 0; i < 26; i++){
            char c = (char)(i + 'a');
            for(int j = 0; j < charCounts[i]; j++) stack.Push(c);
        }
        return stack;
    }

    private string ConvToString(Stack<char> stack){
        StringBuilder sb = new StringBuilder();
        while(stack.Count > 0){
            sb.Append(stack.Pop());
        }
        string result = new string(sb.ToString().Reverse().ToArray());
        return result;
    }
}