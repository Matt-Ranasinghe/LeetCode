public class Solution {
    public int LongestValidParentheses(string s) {
        Stack<int> stack = new Stack<int>();
        int maxLength = 0;
        int n = s.Length;
        int[] endingPoints = new int[n];
        for(int i = 0; i < n; i++){
            if(s[i] == ')'){
                if(stack.Count == 0) continue;
                else{
                    int start = stack.Pop();
                    int parenthesisLength = i + 1 - start;
                    if(start - 1 >= 0) parenthesisLength += endingPoints[start - 1];
                    maxLength = Math.Max(parenthesisLength, maxLength);
                    endingPoints[i] = parenthesisLength;
                }
            }
            else{
                stack.Push(i);
            }
        }
        return maxLength;
    }
}