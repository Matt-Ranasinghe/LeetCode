public class Solution {
    public int MaximumProduct(int[] nums) {
        int smallest = Int32.MaxValue, secondSmallest = Int32.MaxValue;
        int largest = Int32.MinValue, secondLargest = Int32.MinValue, thirdLargest = Int32.MinValue;
        foreach(int num in nums){
            if(largest < num){
                thirdLargest = secondLargest;
                secondLargest = largest;
                largest = num;
            }
            else if(secondLargest < num){
                thirdLargest = secondLargest;
                secondLargest = num;
            }
            else if(thirdLargest < num){
                thirdLargest = num;
            }
            if(smallest > num){
                secondSmallest = smallest;
                smallest = num;
            }
            else if(secondSmallest > num){
                secondSmallest = num;
            }
        }
        int result1 = largest * secondLargest * thirdLargest;
        int result2 = smallest * secondSmallest * largest;
        return Math.Max(result1, result2);
    }
}