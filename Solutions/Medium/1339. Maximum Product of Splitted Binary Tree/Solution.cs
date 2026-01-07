
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
    private const int MOD = (int) 1e9 + 7;
    private long maxProduct = 0;

    public int MaxProduct(TreeNode root) {
        long totalSum = Sum(root);
        DFS(root, totalSum);
        return (int)(maxProduct % MOD);
    }

    private long Sum(TreeNode node) {
        if (node == null) return 0;
        return node.val + Sum(node.left) + Sum(node.right);
    }

    private long DFS(TreeNode node, long totalSum) {
        if (node == null) return 0;
        long left = DFS(node.left, totalSum);
        long right = DFS(node.right, totalSum);
        long subSum = node.val + left + right;
        maxProduct = Math.Max(maxProduct, subSum * (totalSum - subSum));
        return subSum;
    }
}
