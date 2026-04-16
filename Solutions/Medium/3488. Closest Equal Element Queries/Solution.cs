public class Solution {
    public IList<int> SolveQueries(int[] nums, int[] queries) {
        int n = nums.Length;
        int[] distances = new int[n];
        Array.Fill(distances, Int32.MaxValue);
        Dictionary<int, int> firstIndex = new Dictionary<int, int>();
        Dictionary<int, int> lastIndex = new Dictionary<int, int>();
        for(int i = 0; i < n; i++){
            int num = nums[i];
            if(lastIndex.ContainsKey(num)){
                int prev = lastIndex[num];
                distances[i] = i - prev;
                distances[prev] = Math.Min(distances[i], distances[prev]);
            }
            else{
                firstIndex[num] = i;
            }
            lastIndex[num] = i;
        }
        foreach(KeyValuePair<int, int> fi in firstIndex){
            int li = lastIndex[fi.Key];
            if(fi.Value == li) distances[li] = -1;
            else{
                distances[li] = Math.Min(fi.Value + n - li, distances[li]);
                distances[fi.Value] = Math.Min(fi.Value + n - li, distances[fi.Value]);
            }
        }
        IList<int> results = new List<int>();
        foreach(int query in queries){
            results.Add(distances[query]);
        }
        return results;
    }
}