class Solution:
    def countNegatives(self, grid: List[List[int]]) -> int:
        result: int = 0
        row_pointer:int = len(grid[0]) - 1
        col_height: int = len(grid)
        for i, r in enumerate(grid):
            while(r[row_pointer] < 0):
                result += col_height - i
                row_pointer -= 1
                if(row_pointer == -1):
                    return result
        return result