public class Solution {
    private const int MOD = (int) 1e9 + 7;
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences) {
        if(n == m) return (int)(((long) (m - 1) * (n - 1)) % MOD);
        Array.Sort(hFences);
        Array.Sort(vFences);
        HashSet<int> heights = new HashSet<int>();
        HashSet<int> widths = new HashSet<int>();
        int p = hFences.Length, q = vFences.Length;
        for(int i = 0; i < p; i++){
            for(int j = 0; j < i; j++){
                heights.Add(hFences[i] - hFences[j]);
            }
            heights.Add(hFences[i] - 1);
            heights.Add(m - hFences[i]);
        }
        for(int i = 0; i < q; i++){
            for(int j = 0; j < i; j++){
                widths.Add(vFences[i] - vFences[j]);
            }
            widths.Add(vFences[i] - 1);
            widths.Add(n - vFences[i]);
        }
        heights.Add(m - 1);
        widths.Add(n - 1);
        int result = -1;
        foreach(int num in widths){
            if(heights.Contains(num)) result = Math.Max(num, result);
        }
        return result == -1 ? -1 : SquareNum(result);
    }

    private int SquareNum(int x) => (int) (((long) x * x) % MOD);
}
