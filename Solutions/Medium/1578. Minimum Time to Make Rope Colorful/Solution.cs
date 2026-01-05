public class Solution {
    public int MinCost(string colours, int[] neededTime) {
        int n = colours.Length;
        char prev = '-';
        int removeCost = 0, result = 0;
        for(int i = 0; i < n; i++){
            if(prev != colours[i]){
                prev = colours[i];
                removeCost = neededTime[i];
            }
            else if(removeCost >= neededTime[i]){
                result += neededTime[i];
            }
            else{
                result += removeCost;
                removeCost = neededTime[i];
            }
        }
        return result;
    }
}