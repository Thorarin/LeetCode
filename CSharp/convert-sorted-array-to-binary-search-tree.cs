// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/

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
    public TreeNode SortedArrayToBST(int[] nums) {
        return SortedArrayToBST(nums, 0, nums.Length);
    }

    private TreeNode SortedArrayToBST(int[] nums, int start, int length) {
        if (length <= 0) return null;
        if (length == 1) {
            return new TreeNode(nums[start]);
        }

        int pos = start + length / 2;
        var node = new TreeNode(nums[pos]);
        node.left = SortedArrayToBST(nums, start, pos - start);
        node.right = SortedArrayToBST(nums, pos + 1, length - pos + start - 1);
        return node;
   }
}