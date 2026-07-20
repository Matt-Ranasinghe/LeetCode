public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        var l = grid.Length;
        var oneGridArray = new List<int>();

        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
                oneGridArray.Add(grid[i][j]);
        }

        for (int j = 0; j < k; j++)
        {
            int t = oneGridArray[oneGridArray.Count() - 1];
            for (int i = oneGridArray.Count() - 1; i > 0; i--)
                oneGridArray[i] = oneGridArray[i - 1];
            oneGridArray[0] = t;
        }

        var index = 0;
        for (int i = 0; i < l; i++)
            for (int j = 0; j < grid[i].Length; j++)
            {
                grid[i][j] = oneGridArray[index];
                index++;
            }
  
        return grid;
    }
}