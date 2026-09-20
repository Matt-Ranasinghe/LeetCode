public class Solution {
    public IList<string> MaxNumOfSubstrings(string s) {
        int n = s.Length;
        int[] left = new int[26];
        int[] right = new int[26];
        Array.Fill(left, -1);
        for (int i = 0; i < n; i++) {
            int c = s[i] - 'a';
            if (left[c] == -1) left[c] = i;
            right[c] = i;
        }
        List<(int left, int right)> validIntervals = new List<(int, int)>();
        for (int i = 0; i < 26; i++) {
            if (left[i] == -1) continue;

            int l = left[i];
            int r = right[i];
            bool isValid = true;
            for (int j = l; j <= r; j++) {
                int c = s[j] - 'a';
                l = Math.Min(l, left[c]);
                r = Math.Max(r, right[c]);
                if (l < left[i]) {
                    isValid = false;
                    break;
                }
            }
            if (isValid) {
                validIntervals.Add((l, r));
            }
        }
        validIntervals.Sort((a, b) => a.right.CompareTo(b.right));
        List<string> result = new List<string>();
        int lastRight = -1;
        foreach ((int left, int right) interval in validIntervals) {
            if (interval.left > lastRight) {
                result.Add(s.Substring(interval.left, interval.right - interval.left + 1));
                lastRight = interval.right;
            }
        }
        return result;
    }
}