public class Solution {
    public int UniqueXorTriplets(int[] nums) {
        int n = nums.Length;
        HashSet<int> pairs = new HashSet<int>();
        for(int i = 0; i < n; i++){
            for(int j = i; j < n; j++){
                pairs.Add(nums[i] ^ nums[j]);
            }
        }
        HashSet<int> triples = new HashSet<int>();
        foreach(int num in pairs){
            for(int k = 0; k < n; k++){
                triples.Add(num ^ nums[k]);
            }
        }
        return triples.Count;
    }
}