public class Solution {
    public int CountCoveredBuildings(int n, int[][] buildings) {
        Dictionary<int, int[]> columnDict = new Dictionary<int, int[]>();
        Dictionary<int, int[]> rowDict = new Dictionary<int, int[]>();
        foreach(int[] building in buildings){
            if (!columnDict.ContainsKey(building[1])){
                columnDict[building[1]] = new int[2] {building[0], building[0]};
            }
            else{
                int[] range = columnDict[building[1]];
                if (range[0] > building[0]){
                    range[0] = building[0];
                }
                else if (range[1] < building[0]){
                    range[1] = building[0];
                }
                columnDict[building[1]] = range;
            }
            if (!rowDict.ContainsKey(building[0])){
                rowDict[building[0]] = new int[2] {building[1], building[1]};
            }
            else{
                int[] range = rowDict[building[0]];
                if (range[0] > building[1]){
                    range[0] = building[1];
                }
                else if (range[1] < building[1]){
                    range[1] = building[1];
                }
                rowDict[building[0]] = range;
            }
        }
        int result = 0;
        foreach(int[] building in buildings){
            int[] colRange = columnDict[building[1]], rowRange = rowDict[building[0]];
            if (colRange[0] < building[0] && colRange[1] > building[0] && rowRange[0] < building[1] && rowRange[1] > building[1]){
                result++;
            }
        }
        return result;
    }
}