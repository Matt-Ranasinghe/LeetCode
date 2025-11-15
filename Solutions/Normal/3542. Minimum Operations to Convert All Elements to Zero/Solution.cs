public class Solution {
    public int MinOperations(int[] nums) {
        int result = 0, n = nums.Length;
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < n; i++){
            if(nums[i] == 0){
                if(stack.Count > 0) stack.Clear();
                continue;
            }
            while(stack.Count > 0 && stack.Peek() > nums[i]){
                stack.Pop();
            }
            if(stack.Count == 0 || stack.Peek() < nums[i]){
                stack.Push(nums[i]);
                result++;
            }
        }
        return result;
    }
}