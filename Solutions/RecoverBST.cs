using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public static class RecoverBST
    {
        public static void function(TreeNode root)
        {
            List<int> list = new List<int>();
            inorder(root, list);
            int mid = list.IndexOf(root.val);
            list.Sort();
            TreeNode node = helper(0, list.Count - 1, list);
        }
        public static TreeNode helper(int left, int right, List<int> list)
        {
            if (left > right)
                return null;

            int mid = (left + right) / 2;
            TreeNode node = new TreeNode(list[mid]);
            node.left = helper(left, mid - 1, list);
            node.right = helper(mid + 1, right, list);
            return node;
        }
        public static void inorder(TreeNode root, List<int> list)
        {
            if (root == null)
                return;

            inorder(root.left, list);
            list.Add(root.val);
            inorder(root.right, list);
        }
    }

    
}
