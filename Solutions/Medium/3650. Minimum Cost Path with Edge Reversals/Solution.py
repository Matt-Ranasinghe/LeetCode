class Solution:
    def minCost(self, n: int, edges: List[List[int]]) -> int:
        dictEdges: Dict[int:List[Tuple[int, int]]] = {}
        for i in range(0, n):
            dictEdges[i] = []
        for edge in edges:
            dictEdges[edge[0]].append((edge[1], edge[2]))
            dictEdges[edge[1]].append((edge[0], edge[2] * 2))
        seen: Set[int] = set()
        heap = [(0,0)]
        while len(heap) > 0:
            nextNode = heapq.heappop(heap)
            if(nextNode[1] in seen):
                continue
            seen.add(nextNode[1])
            if(nextNode[1] == n - 1):
                return nextNode[0]
            for connection in dictEdges[nextNode[1]]:
                heapq.heappush(heap, (nextNode[0] + connection[1], connection[0]))
        return -1