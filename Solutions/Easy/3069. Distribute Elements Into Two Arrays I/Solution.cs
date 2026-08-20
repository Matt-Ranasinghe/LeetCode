public class Solution {
    public int[] ResultArray(int[] nums) {
        List<int> arr1 = new List<int>(), arr2 = new List<int>();
        int arr1Tail = nums[0], arr2Tail = nums[1];
        int n = nums.Length;
        arr1.Add(nums[0]);
        arr2.Add(nums[1]);
        for(int i = 2; i < n; i++){
            if(arr1Tail > arr2Tail){
                arr1.Add(nums[i]);
                arr1Tail = nums[i];
            }
            else{
                arr2.Add(nums[i]);
                arr2Tail = nums[i];
            }
        }
        arr1.AddRange(arr2);
        return arr1.ToArray();
    }
}