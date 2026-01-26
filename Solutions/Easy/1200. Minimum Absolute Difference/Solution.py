class Solution:
    def minimumAbsDifference(self, arr: List[int]) -> List[List[int]]:
        arr.sort()
        n: int = len(arr)
        result: List[List[int]] = []
        diff: float = float('inf')
        for i in range(0, n - 1):
            newDiff = arr[i + 1] - arr[i]
            if(diff > newDiff):
                result.clear()
                result.append([arr[i], arr[i + 1]])
                diff = newDiff
            elif(diff == newDiff):
                result.append([arr[i], arr[i + 1]])
        return result
