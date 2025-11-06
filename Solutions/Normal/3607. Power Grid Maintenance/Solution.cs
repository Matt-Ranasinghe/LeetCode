public class Solution {
    public int[] ProcessQueries(int c, int[][] connections, int[][] queries) {
        var dsu = new DSU(c + 1);
        foreach (var edge in connections) {
            dsu.Union(edge[0], edge[1]);
        }
        var compMap = new Dictionary<int, SortedSet<int>>();
        for (int i = 1; i <= c; i++) {
            int root = dsu.Find(i);
            if (!compMap.ContainsKey(root))
                compMap[root] = new SortedSet<int>();
            compMap[root].Add(i);
        }
        bool[] online = new bool[c + 1];
        Array.Fill(online, true);
        var result = new List<int>();
        foreach (var query in queries) {
            int type = query[0];
            int x = query[1];
            int root = dsu.Find(x);

            if (type == 1) {
                if (online[x]) {
                    result.Add(x);
                } else {
                    if (!compMap.ContainsKey(root) || compMap[root].Count == 0)
                        result.Add(-1);
                    else
                        result.Add(compMap[root].Min);
                }
            } 
            else {
                if (online[x]) {
                    online[x] = false;
                    if (compMap.ContainsKey(root))
                        compMap[root].Remove(x);
                }
            }
        }

        return result.ToArray();
    }
    private class DSU {
        private int[] parent;
        private int[] rank;

        public DSU(int n) {
            parent = new int[n];
            rank = new int[n];
            for (int i = 0; i < n; i++)
                parent[i] = i;
        }

        public int Find(int x) {
            if (parent[x] != x)
                parent[x] = Find(parent[x]);
            return parent[x];
        }

        public void Union(int a, int b) {
            int pa = Find(a);
            int pb = Find(b);
            if (pa == pb) return;

            if (rank[pa] < rank[pb])
                parent[pa] = pb;
            else if (rank[pb] < rank[pa])
                parent[pb] = pa;
            else {
                parent[pb] = pa;
                rank[pa]++;
            }
        }
    }
}