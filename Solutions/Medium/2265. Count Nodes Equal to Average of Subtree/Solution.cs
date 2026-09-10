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
    public int AverageOfSubtree(TreeNode root) {
        return AvgTreeSearch(root).result;
    }

    private (int tot, int count, int result) AvgTreeSearch(TreeNode node){
        (int tot, int count, int result) left = (0, 0, 0);
        (int tot, int count, int result) right = (0, 0, 0);
        if(node.left is not null){
            left = AvgTreeSearch(node.left);
        }
        if(node.right is not null){
            right = AvgTreeSearch(node.right);
        }
        int total = node.val + left.tot + right.tot;
        int nodeCount = 1 + left.count + right.count;
        int matches = total / nodeCount == node.val ? 1 : 0;
        return (total, nodeCount, matches + left.result + right.result);
    }
}