public class Solution {
    public string ReverseParentheses(string s) {
        Stack<int> stack = new Stack<int>();
        int n = s.Length;
        List<(int start, int end)> pairs = new List<(int start, int end)>();
        for(int i = 0; i < n; i++){
            if(s[i] == '(') stack.Push(i);
            else if(s[i] == ')') pairs.Add((stack.Pop() + 1, i - 1));
        }
        char[] arr = s.ToCharArray();
        foreach((int start, int end) pair in pairs){
            Reverse(pair.start, pair.end, arr);
        }
        StringBuilder sb = new StringBuilder();
        foreach(char c in arr){
            if(c != '(' && c != ')') sb.Append(c);
        }
        return sb.ToString();
    }

    private void Reverse(int left, int right, char[] arr){
        while(left < right){
            char temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
        return;
    }
}