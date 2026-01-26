public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(arr);
        int diff = Int32.MaxValue, n = arr.Length;
        for(int i = 0; i < n - 1; i++){
            int newDiff = arr[i + 1] - arr[i];
            if(diff > newDiff){
                result.Clear();
                result.Add(new List<int>{arr[i], arr[i + 1]});
                diff = newDiff;
            }
            else if(diff == newDiff){
                result.Add(new List<int>{arr[i], arr[i + 1]});
            }
        }
        return result;
    }
}