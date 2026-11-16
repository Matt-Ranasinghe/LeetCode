public class Solution {
    public string DigitSum(string s, int k) {
        while (s.Length > k) {
            string temp = "";
            int n = s.Length;
            for (int i = 0; i < n; i += k) {
                int val = 0;
                for (int j = i; j < Math.Min(i + k, n); ++j) {
                    val += s[j] - '0';
                }
                temp += val.ToString();
            }
            s = temp;
        }
        return s;
    }
}