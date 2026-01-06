
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public int MaxLevelSum(TreeNode root) {
        int maxSum = Int32.MinValue, curSum = 0, depth = 0, result = 0;
        Queue<(TreeNode node, int depth)> queue = new Queue<(TreeNode node, int depth)>();
        queue.Enqueue((root, depth));
        while(queue.Count > 0){
            if(queue.Peek().depth != depth){
                if(maxSum < curSum){
                    maxSum = curSum;
                    result = depth + 1;
                }
                depth++;
                curSum = 0;
            }
            (TreeNode node, int depth) value = queue.Dequeue();
            curSum += value.node.val;
            if(value.node.left != null) queue.Enqueue((value.node.left, depth + 1));
            if(value.node.right != null) queue.Enqueue((value.node.right, depth + 1));
        }
        if(maxSum < curSum) result = depth + 1;
        return result;
    }
}