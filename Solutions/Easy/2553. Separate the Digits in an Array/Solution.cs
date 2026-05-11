public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> result = new List<int>();
        int n = nums.Length;
        for(int i = n - 1; i >= 0; i--){
            int num = nums[i];
            while(num > 0){
                result.Add(num % 10);
                num /= 10;
            }
        }
        result.Reverse();
        return result.ToArray();
    }
}