public class Solution {
    public int[] FindSubtreeSizes(int[] parent, string s) {
        int n = parent.Length;
        int[] result = new int[n];
        int[] lastSeen = new int[26];
        Dictionary<int, List<int>> tree = new Dictionary<int, List<int>>();
        for(int i = 1; i < n; i++){
            int parNode = parent[i];
            if(!tree.ContainsKey(parNode)) tree[parNode] = new List<int>();
            tree[parNode].Add(i);
        }
        Array.Fill(lastSeen, -1);
        DFS(result, 0, lastSeen, s, tree, 0);
        tree.Clear();
        for(int i = 1; i < n; i++){
            int parNode = result[i];
            if(!tree.ContainsKey(parNode)) tree[parNode] = new List<int>();
            tree[parNode].Add(i);
        }
        DFSSum(result, 0, tree);
        return result;
    }

    private void DFS(int[] result, int pos, int[] lastSeen, string s, Dictionary<int, List<int>> tree, int parent){
        int charPos = s[pos] - 'a';
        int lastSeenTemp = lastSeen[charPos];
        if(lastSeenTemp == -1){
            lastSeen[charPos] = pos;
            result[pos] = parent;
        }
        else{
            result[pos] = lastSeenTemp;
            lastSeen[charPos] = pos;
        }
        if(tree.ContainsKey(pos)){
            foreach(int child in tree[pos]){
                DFS(result, child, lastSeen, s, tree, pos);
            }
        }
        lastSeen[charPos] = lastSeenTemp;
    }

    private int DFSSum(int[] result, int pos, Dictionary<int, List<int>> tree){
        result[pos] = 1;
        if(!tree.ContainsKey(pos)) return 1;
        foreach(int child in tree[pos]){
            result[pos] += DFSSum(result, child, tree);
        }
        return result[pos];
    }
}