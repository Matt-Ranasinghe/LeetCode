public class Solution {
    public string FindLexSmallestString(string s, int a, int b) {
        Queue<string> queue = new Queue<string>();
        HashSet<string> seen = new HashSet<string>();
        seen.Add(s);
        queue.Enqueue(s);
        int n = s.Length;
        string result = "A";
        while(queue.Count > 0){
            string next = queue.Dequeue();
            string addFirst = AddToOdd(next, a, n);
            if(!seen.Contains(addFirst)){
                queue.Enqueue(addFirst);
                seen.Add(addFirst);
            }
            string rotateFirst = Rotate(next, b, n);
            if(!seen.Contains(rotateFirst)){
                queue.Enqueue(rotateFirst);
                seen.Add(rotateFirst);
            }
            if(result.CompareTo(next) == 1) {
                result = next;
            }
        }
        return result;
    }

    private string AddToOdd(string s, int a, int n){
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < n; i++){
            if(i % 2 == 1) {
                int addOn = s[i] - '0' + a;
                addOn %= 10;
                sb.Append((char) (addOn + '0'));
            }
            else sb.Append(s[i]);
        }
        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }

    private string Rotate(string s, int b, int n){
        StringBuilder sb = new StringBuilder();
        for(int i = b; i < n + b; i++){
            sb.Append(s[i % n]);
        }
        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }
}