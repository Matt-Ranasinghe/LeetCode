/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        TreeNode result = DeepestNode(root, 0).node;
        return result;
    }

    private (TreeNode node, int depth) DeepestNode(TreeNode node, int depth){
        (TreeNode nodeChoice, int depth) result;
        if(node.left == null && node.right == null) {
            return(node, depth);
        }
        else if(node.left == null){
            result = DeepestNode(node.right, depth + 1);
        }
        else if(node.right == null){
            result = DeepestNode(node.left, depth + 1);
        }
        else{
            var left = DeepestNode(node.left, depth + 1);
            var right = DeepestNode(node.right, depth + 1);
            if(left.depth > right.depth) result = left;
            else if(left.depth < right.depth) result = right;
            else result = (node, left.depth);
        }
        return result;
    }
}