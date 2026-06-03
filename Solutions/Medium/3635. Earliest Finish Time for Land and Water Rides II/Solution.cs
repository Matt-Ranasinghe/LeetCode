public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int n = landDuration.Length, m = waterDuration.Length;
        int earliestLandFinish = Int32.MaxValue, earliestWaterFinish = Int32.MaxValue;
        for(int i = 0; i < n; i++){
            earliestLandFinish = Math.Min(earliestLandFinish, (landStartTime[i] + landDuration[i]));
        }
        for(int i = 0; i < m; i++){
            earliestWaterFinish = Math.Min(earliestWaterFinish, (waterStartTime[i] + waterDuration[i]));
        }
        int result = Int32.MaxValue;
        for(int i = 0; i < m; i++){
            result = Math.Min(result, Math.Max(earliestLandFinish, waterStartTime[i]) + waterDuration[i]);
        }
        for(int i = 0; i < n; i++){
            result = Math.Min(result, Math.Max(earliestWaterFinish, landStartTime[i]) + landDuration[i]);
        }
        return result;
    }
}