using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static class LinkedListInBT
    {
        public static bool result;
        public static bool IsSubPath(TreeNode root, ListNode head)
        {
            result = false;
            pre_order(root, head);
            return result;
        }
        public static void pre_order(TreeNode root, ListNode head)
        {
            if (result == true)
                return;

            if (root == null)
                return;

            if (root.val == head.val)
            {
                helper(root, head);
            }
            pre_order(root.left, head);
            pre_order(root.right, head);
        }
        public static void helper(TreeNode root, ListNode head)
        {
            if (root == null || result == true)
                return;

            if (head.next == null)
            {
                result = true;
                return;
            }
            if (root.val == head.val)
            {
                helper(root.left, head.next);
                helper(root.right, head.next);
            }
            
        }
    }
}
