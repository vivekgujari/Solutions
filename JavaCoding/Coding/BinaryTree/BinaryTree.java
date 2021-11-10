import java.util.*;

public class BinaryTree {
	
	private class Node {
		private int val;
		private Node leftChild;
		private Node rightChild;
		private Node(int val)
		{
			this.val = val;
		}
		
		@Override
		public String toString()
		{
			return String.format("Node = " + this.val);
		}
	}

	private Node root;
	
	public void Insert(int val)
	{
		if(root == null)
		{
			root = new Node(val);
			return;
		}
		Node current = root;
		while(true)
		{
			if(val < current.val)
			{
				if(current.leftChild == null)
				{
					current.leftChild = new Node(val); // we found the parent for the inserting element
					break;
				}
				current = current.leftChild;
			}
			else
			{
				if(current.rightChild == null)
				{
					current.rightChild = new Node(val);// we found the parent for the inserting element
					break;
				}
				current = current.rightChild;
			}
		}
	}
	
	public List<Integer> inorder_traversal()
	{
		List<Integer> list = new ArrayList<>();
		inorder(this.root, list);
		return list;
	}
	private void inorder(Node root, List<Integer> list)
	{
		if(root == null)
			return;
		
		inorder(root.leftChild, list);
		list.add(root.val);
		inorder(root.rightChild, list);
	}
	
	public List<Integer> preorder_traversal()
	{
		List<Integer> list = new ArrayList<>();
		preorder(this.root, list);
		return list;
	}
	private void preorder(Node root, List<Integer> list)
	{
		if(root == null)
			return;
		
		list.add(root.val);
		inorder(root.leftChild, list);
		inorder(root.rightChild, list);
	}
	
	public List<Integer> postorder_traversal()
	{
		List<Integer> list = new ArrayList<>();
		preorder(this.root, list);
		return list;
	}
	private void postorder(Node root, List<Integer> list)
	{
		if(root == null)
			return;
		
		inorder(root.leftChild, list);
		inorder(root.rightChild, list);
		list.add(root.val);
	}

	public int getHeight()
	{
		return height(root);
	}
	
	private int height(Node root)
	{
		if(root == null)
			return 0;
		
		return 1 + Math.max(height(root.leftChild), height(root.rightChild));
		
	}
	
	public List<Integer> getNodesAtKdistance(int K)
	{
		List<Integer> list = new ArrayList<>();
		getNodesAtK(K, list, this.root);
		return list;
	}
	
	public void getNodesAtK(int K, List<Integer> list, Node root)
	{
		if(K == 0)
		{
			list.add(root.val);
		}
		getNodesAtK(K--, list, root.leftChild);
		getNodesAtK(K--, list, root.rightChild);
	}
	
	public List<Integer> level_order_traversal()
	{
		List<Integer> list = new ArrayList<>();
		for(int i = 0; i < getHeight(); i++)
		{
			list.addAll(getNodesAtKdistance(i));
		}
		return list;
	}
	
	
}
