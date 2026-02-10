public class Solution {
    public int LongestBalanced(int[] nums) 
    {
        int n = nums.Length;
        int result = 0;
        for (int i = 0; i < n; i++){
            int even = 0;
            int odd = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int j = i; j < n; j++)
            {
                if(dict.ContainsKey(nums[j])) {
                    dict[nums[j]]++;
                }
                else{
                    if (nums[j] % 2 == 0) even++;
                    else odd++;
                    dict[nums[j]] = 1;
                }
                if (odd == even){
                    result = Math.Max(result, j-i+1);
                }
            }
        }
        return result;
    }
}