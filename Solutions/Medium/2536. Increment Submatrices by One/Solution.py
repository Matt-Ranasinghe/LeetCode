class Solution:
    def rangeAddQueries(self, n: int, queries: List[List[int]]) -> List[List[int]]:
        matrix_result: List[List[int]] = [[0 for _ in range(n)] for _ in range(n)]
        for query in queries:
            for i in range(query[0], query[2] + 1):
                matrix_result[i][query[1]] += 1
                if(query[3] < n - 1):
                    matrix_result[i][query[3] + 1] -= 1
        for row in matrix_result:
            for i in range(1, len(row)):
                row[i] += row[i - 1]
        return matrix_result