public class Solution {
    public int SumFourDivisors(int[] nums) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        int result = 0;
        foreach(int num in nums){
            if(seen.ContainsKey(num)) result += seen[num];
            else{
                int factors = FourDivisors(num);
                seen[num] = factors;
                result += factors;
            }
        }
        return result;
    }

    private int FourDivisors(int num){
        int result = 0;
        for(int i = 2; i <= (int)Math.Sqrt((double)num); i++){
            if(num % i == 0){
                if(i * i == num) return 0;
                if(result != 0) return 0;
                result = i + (num / i) + 1 + num;
            }
        }
        return result;
    }
}