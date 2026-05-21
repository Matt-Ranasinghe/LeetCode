public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        TrieNode root = new TrieNode();
        Stack<int> stack = new Stack<int>();
        foreach(int num in arr1){
            TrieNode currentPos = root;
            int remainder = num;
            while(remainder > 0){
                stack.Push(remainder % 10);
                remainder /= 10;
            }
            while(stack.Count > 0){
                currentPos = currentPos.updateTrie(stack.Pop());
            }
        }
        int result = 0;
        foreach(int num in arr2){
            TrieNode currentPos = root;
            int remainder = num;
            int maximumDepth = 0;
            while(remainder > 0){
                stack.Push(remainder % 10);
                remainder /= 10;
            }
            while(stack.Count > 0){
                int digit = stack.Pop();
                if(currentPos.getNode(digit) == null){
                    stack.Clear();
                }
                else{
                    currentPos = currentPos.getNode(digit);
                    maximumDepth++;
                }
            }
            result = Math.Max(maximumDepth, result);
        }
        return result;
    }
}

public class TrieNode{
    private TrieNode[] nodes;
    
    public TrieNode(){
        nodes = new TrieNode[10];
    }

    public TrieNode updateTrie(int val){
        if(nodes[val] == null) nodes[val] = new TrieNode();
        return nodes[val];
    }

    public TrieNode getNode(int val){
        return nodes[val];
    }
}