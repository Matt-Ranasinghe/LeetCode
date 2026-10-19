public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        int targetCount = 0;
        int smallerThan = 0;
        foreach(int num in nums){
            if(num < target) smallerThan++;
            else if(num == target) targetCount++;
        }
        List<int> result = new List<int>();
        for(int i = smallerThan; i < smallerThan + targetCount; i++){
            result.Add(i);
        }
        return result;
    }
}