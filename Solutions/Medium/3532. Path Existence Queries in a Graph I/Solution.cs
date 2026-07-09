public class Solution {
    public bool[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries) {
        int[] groupings = CreateRange(n, nums, maxDiff);
        int m = queries.Length;
        bool[] result = new bool[m];
        for(int i = 0; i < m; i++){
            if(groupings[queries[i][0]] == groupings[queries[i][1]]){
                result[i] = true;
            }
        }
        return result;
    }

    private int[] CreateRange(int n, int[] nums, int maxDiff){
        int currentId = 0;
        int[] result = new int[n];
        result[0] = currentId;
        for(int i = 1; i < n; i++){
            if(nums[i] - nums[i - 1] > maxDiff){
                currentId++;
            }
            result[i] = currentId;
        }
        return result;
    }
}